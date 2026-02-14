using DesignPatternChallenge.Builders;

new class Program {
    public static void Main(string[] args) {
        var builder = new FluentSalesReportBuilder();
        
        // Problema 1: Construtor com muitos parâmetros - difícil de ler e usar
        var report1 = builder
            .WithTitle("Vendas Mensais")
            .WithFormat("PDF")
            .WithPeriod(new DateTime(2024, 1, 1), new DateTime(2024, 1, 31))
            .WithHeader("Relatório de Vendas")
            .WithFooter("Confidencial")
            .WithCharts("Bar")
            .WithSummary()
            .WithColumns("Produto", "Quantidade", "Valor")
            .WithFilters("Status=Ativo")
            .WithSorting("Valor")
            .WithGrouping("Categoria")
            .WithTotals()
            .WithOrientation("Portrait")
            .WithPageSize("A4")
            .WithPageNumbers(true)
            .WithCompanyLogo("logo.png")
            .WithWaterMark("Confidencial")
            .Build();

        report1.Generate();

        // Problema 2: Muitos setters - ordem não importa, pode esquecer configurações obrigatórias
        var report2 = builder
            .WithTitle("Relatório Trimestral")
            .WithFormat("Excel")
            .WithPeriod(new DateTime(2024, 1, 1), new DateTime(2024, 3, 31))
            .WithColumns("Vendedor", "Região", "Total")
            .WithCharts("Line")
            .WithHeader("Relatório Trimestral")
            .WithGrouping("Região")
            .WithTotals()
            .Build();

        report2.Generate();

        // Problema 3: Relatórios com configurações parecidas exigem repetir muito código
        var report3 = builder
            .WithTitle("Vendas Anuais")
            .WithFormat("PDF")
            .WithPeriod(new DateTime(2024, 1, 1), new DateTime(2024, 12, 31))
            .WithHeader("Relatório de Vendas")
            .WithFooter("Confidencial")
            .WithColumns("Produto", "Quantidade", "Valor")
            .WithCharts("Pie")
            .WithTotals()
            .WithOrientation("Landscape")
            .WithPageSize("A4")
            .Build();

        report3.Generate();
    }
}