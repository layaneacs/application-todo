namespace Todo.Application.Todo
{
    public class TodoInput
    {
        public string Descricao { get; set; }
        public string Titulo { get; set; }
        public string Status { get; set; }
        internal string Identificador { get; private set; }

        public void SetIdentificador(string id)
        {
            this.Identificador = id;
        }

    }
}