namespace QuickBuy.Dominio.Entidades
{
    public class Produto: Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Nome))
                AdicionarCritica("Nome do produto não foi informado.");

            if (Preco <= 0)
                AdicionarCritica("Preço não foi informado");
            
        }
    }
}
