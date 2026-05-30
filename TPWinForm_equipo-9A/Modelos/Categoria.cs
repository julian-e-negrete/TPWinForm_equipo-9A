namespace TPWinForm_equipo_9A.Modelos
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        public override string ToString() => Descripcion;
    }
}
