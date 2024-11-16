namespace CadastroEventos
{
    public partial class ResumoPage : ContentPage
    {
        public Evento Evento { get; set; }

        public Command EditarEventoCommand { get; }

        public ResumoPage(Evento evento)
        {
            InitializeComponent();
            Evento = evento;
            BindingContext = this;
        }
    }
}
