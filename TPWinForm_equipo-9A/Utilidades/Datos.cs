using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using TPWinForm_equipo_9A.Modelos;

namespace TPWinForm_equipo_9A.Utilidades
{
    public static class Datos
    {
        private static string ConnectionString =>
            ConfigurationManager.ConnectionStrings["CatalogoDB"].ConnectionString;

        private static SqlConnection GetConnection() =>
            new SqlConnection(ConnectionString);


        public static List<Marca> ObtenerMarcas()
        {
            var lista = new List<Marca>();
            const string sql = "SELECT Id, Descripcion FROM MARCAS ORDER BY Descripcion";

            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(sql, conn))
            {
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                        lista.Add(MapearMarca(reader));
            }
            return lista;
        }


        public static List<Categoria> ObtenerCategorias()
        {
            var lista = new List<Categoria>();
            const string sql = "SELECT Id, Descripcion FROM CATEGORIAS ORDER BY Descripcion";

            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(sql, conn))
            {
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                        lista.Add(MapearCategoria(reader));
            }
            return lista;
        }


        public static List<Articulo> ObtenerArticulos()
        {
            var lista = new List<Articulo>();
            const string sql = @"
                SELECT a.Id, a.Codigo, a.Nombre, a.Descripcion, a.Precio,
                       m.Id AS IdMarca,      m.Descripcion AS NombreMarca,
                       c.Id AS IdCategoria,  c.Descripcion AS NombreCategoria

                FROM   ARTICULOS a

                LEFT JOIN MARCAS     m ON a.IdMarca     = m.Id
                LEFT JOIN CATEGORIAS c ON a.IdCategoria = c.Id
                ORDER BY a.Nombre";

            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(sql, conn))
            {
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                        lista.Add(MapearArticulo(reader));
            }
            return lista;
        }

        public static Articulo ObtenerArticuloPorId(int id)
        {
            const string sql = @"
                SELECT a.Id, a.Codigo, a.Nombre, a.Descripcion, a.Precio,
                       m.Id AS IdMarca,      m.Descripcion AS NombreMarca,
                       c.Id AS IdCategoria,  c.Descripcion AS NombreCategoria
                FROM   ARTICULOS a
                LEFT JOIN MARCAS     m ON a.IdMarca     = m.Id
                LEFT JOIN CATEGORIAS c ON a.IdCategoria = c.Id
                WHERE a.Id = @id";

            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                    if (reader.Read())
                        return MapearArticulo(reader);
            }
            return null;
        }

        public static List<Articulo> BuscarArticulos(string campo, string valor)
        {
            string filtro;
            switch (campo)
            {
                case "Código":    filtro = "a.Codigo LIKE @valor";          break;
                case "Marca":     filtro = "m.Descripcion LIKE @valor";     break;
                case "Categoría": filtro = "c.Descripcion LIKE @valor";     break;
                default:          filtro = "a.Nombre LIKE @valor";          break;
            }

            string sql = $@"
                SELECT a.Id, a.Codigo, a.Nombre, a.Descripcion, a.Precio,
                       m.Id AS IdMarca,      m.Descripcion AS NombreMarca,
                       c.Id AS IdCategoria,  c.Descripcion AS NombreCategoria
                FROM   ARTICULOS a
                LEFT JOIN MARCAS     m ON a.IdMarca     = m.Id
                LEFT JOIN CATEGORIAS c ON a.IdCategoria = c.Id
                WHERE {filtro}
                ORDER BY a.Nombre";

            var lista = new List<Articulo>();
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@valor", $"%{valor}%");
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                        lista.Add(MapearArticulo(reader));
            }
            return lista;
        }

        public static List<Imagen> ObtenerImagenesPorArticulo(int idArticulo)
        {
            var lista = new List<Imagen>();
            const string sql = "SELECT Id, IdArticulo, ImagenUrl FROM IMAGENES WHERE IdArticulo = @id";

            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@id", idArticulo);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                        lista.Add(new Imagen
                        {
                            Id         = (int)reader["Id"],
                            IdArticulo = (int)reader["IdArticulo"],
                            ImagenUrl  = reader["ImagenUrl"].ToString()
                        });
            }
            return lista;
        }

        public static int AgregarArticulo(Articulo a)
        {
            const string sql = @"
                INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio)
                VALUES (@codigo, @nombre, @descripcion, @idMarca, @idCategoria, @precio);
                SELECT SCOPE_IDENTITY();";

            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@codigo",      a.Codigo);
                cmd.Parameters.AddWithValue("@nombre",      a.Nombre);
                cmd.Parameters.AddWithValue("@descripcion", a.Descripcion);
                cmd.Parameters.AddWithValue("@idMarca",     a.Marca     != null ? (object)a.Marca.Id     : DBNull.Value);
                cmd.Parameters.AddWithValue("@idCategoria", a.Categoria != null ? (object)a.Categoria.Id : DBNull.Value);
                cmd.Parameters.AddWithValue("@precio",      a.Precio);
                conn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public static void AgregarImagen(int idArticulo, string url)
        {
            const string sql = "INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@idArticulo, @url)";

            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@idArticulo", idArticulo);
                cmd.Parameters.AddWithValue("@url",        url);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void AgregarMarca(Marca m)
        {
            const string sql = "INSERT INTO MARCAS (Descripcion) VALUES (@descripcion)";

            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@descripcion", m.Descripcion);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void AgregarCategoria(Categoria c)
        {
            const string sql = "INSERT INTO CATEGORIAS (Descripcion) VALUES (@descripcion)";

            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@descripcion", c.Descripcion);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // ── UPDATE ────────────────────────────────────────────────────────────

        public static void ModificarArticulo(Articulo a)
        {
            const string sqlArticulo = @"
                UPDATE ARTICULOS
                SET Codigo      = @codigo,
                    Nombre      = @nombre,
                    Descripcion = @descripcion,
                    IdMarca     = @idMarca,
                    IdCategoria = @idCategoria,
                    Precio      = @precio
                WHERE Id = @id";

            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(sqlArticulo, conn))
            {
                cmd.Parameters.AddWithValue("@id",          a.Id);
                cmd.Parameters.AddWithValue("@codigo",      a.Codigo);
                cmd.Parameters.AddWithValue("@nombre",      a.Nombre);
                cmd.Parameters.AddWithValue("@descripcion", a.Descripcion);
                cmd.Parameters.AddWithValue("@idMarca",     a.Marca     != null ? (object)a.Marca.Id     : DBNull.Value);
                cmd.Parameters.AddWithValue("@idCategoria", a.Categoria != null ? (object)a.Categoria.Id : DBNull.Value);
                cmd.Parameters.AddWithValue("@precio",      a.Precio);
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            using (var conn = GetConnection())
            using (var cmd = new SqlCommand("DELETE FROM IMAGENES WHERE IdArticulo = @id", conn))
            {
                cmd.Parameters.AddWithValue("@id", a.Id);
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            foreach (var img in a.Imagenes)
            {
                using (var conn = GetConnection())
                using (var cmd = new SqlCommand("INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@id, @url)", conn))
                {
                    cmd.Parameters.AddWithValue("@id",  a.Id);
                    cmd.Parameters.AddWithValue("@url", img.ImagenUrl);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void ModificarMarca(Marca m)
        {
            const string sql = "UPDATE MARCAS SET Descripcion = @descripcion WHERE Id = @id";

            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@id",          m.Id);
                cmd.Parameters.AddWithValue("@descripcion", m.Descripcion);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void ModificarCategoria(Categoria c)
        {
            const string sql = "UPDATE CATEGORIAS SET Descripcion = @descripcion WHERE Id = @id";

            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@id",          c.Id);
                cmd.Parameters.AddWithValue("@descripcion", c.Descripcion);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }


        public static void EliminarArticulo(int id)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand("DELETE FROM IMAGENES WHERE IdArticulo = @id", conn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            using (var conn = GetConnection())
            using (var cmd = new SqlCommand("DELETE FROM ARTICULOS WHERE Id = @id", conn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void EliminarMarca(int id)
        {
            const string sql = "DELETE FROM MARCAS WHERE Id = @id";

            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void EliminarCategoria(int id)
        {
            const string sql = "DELETE FROM CATEGORIAS WHERE Id = @id";

            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private static Marca MapearMarca(SqlDataReader r) =>
            new Marca { Id = (int)r["Id"], Descripcion = r["Descripcion"].ToString() };

        private static Categoria MapearCategoria(SqlDataReader r) =>
            new Categoria { Id = (int)r["Id"], Descripcion = r["Descripcion"].ToString() };

        private static Articulo MapearArticulo(SqlDataReader r)
        {
            var articulo = new Articulo
            {
                Id          = (int)r["Id"],
                Codigo      = r["Codigo"].ToString(),
                Nombre      = r["Nombre"].ToString(),
                Descripcion = r["Descripcion"].ToString(),
                Precio      = Convert.ToDecimal(r["Precio"])
            };

            if (r["IdMarca"] != DBNull.Value)
                articulo.Marca = new Marca
                {
                    Id          = (int)r["IdMarca"],
                    Descripcion = r["NombreMarca"].ToString()
                };

            if (r["IdCategoria"] != DBNull.Value)
                articulo.Categoria = new Categoria
                {
                    Id          = (int)r["IdCategoria"],
                    Descripcion = r["NombreCategoria"].ToString()
                };

            return articulo;
        }
    }
}
