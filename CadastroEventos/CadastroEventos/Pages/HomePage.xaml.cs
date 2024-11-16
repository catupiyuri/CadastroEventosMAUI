namespace CadastroEventos
{
    public partial class HomePage : ContentPage
    {
        public Evento Evento { get; set; }
        public Command CadastrarEventoCommand { get; set; }

        public HomePage()
        {
            InitializeComponent();
            Evento = new Evento
            {
                DataInicio = DateTime.Now,
                DataTermino = DateTime.Now.AddDays(1)
            };
            CadastrarEventoCommand = new Command(CadastrarEvento);
            BindingContext = this;
        }

        private async void CadastrarEvento()
        {
            await Navigation.PushAsync(new ResumoPage(Evento));
        }
    }
}
