namespace DesignPatternChallenge.Builders;

using DesignPatternChallenge.Models;

public class FluentSalesReportBuilder
{
    private readonly SalesReport _report = new();

    public FluentSalesReportBuilder WithTitle(string title)
    {
        _report.Title = title;
        return this;
    }

    public FluentSalesReportBuilder WithFormat(string format)
    {
        _report.Format = format;
        return this;
    }

    public FluentSalesReportBuilder WithDateRange(DateTime startDate, DateTime endDate)
    {
        _report.StartDate = startDate;
        _report.EndDate = endDate;
        return this;
    }

    public FluentSalesReportBuilder WithHeader(bool includeHeader, string? headerText = null)
    {
        _report.IncludeHeader = includeHeader;
        if (headerText != null)
        {
            _report.HeaderText = headerText;
        }
        return this;
    }

    public FluentSalesReportBuilder WithFooter(bool includeFooter, string? footerText = null)
    {
        _report.IncludeFooter = includeFooter;
        if (footerText != null)
        {
            _report.FooterText = footerText;
        }
        return this;
    }

    public FluentSalesReportBuilder WithCharts(bool includeCharts, string? chartType = null)
    {
        _report.IncludeCharts = includeCharts;
        if (chartType != null)
        {
            _report.ChartType = chartType;
        }
        return this;
    }

    public FluentSalesReportBuilder WithSummary(bool includeSummary)
    {
        _report.IncludeSummary = includeSummary;
        return this;
    }

    public FluentSalesReportBuilder WithColumns(List<string> columns)
    {
        _report.Columns = columns;
        return this;
    }

    public FluentSalesReportBuilder WithFilters(List<string> filters)
    {
        _report.Filters = filters;
        return this;
    }

    public FluentSalesReportBuilder WithSortBy(string sortBy)
    {
        _report.SortBy = sortBy;
        return this;
    }

    public FluentSalesReportBuilder WithGroupBy(string groupBy)
    {
        _report.GroupBy = groupBy;
        return this;
    }

    public FluentSalesReportBuilder WithTotals(bool includeTotals)
    {
        _report.IncludeTotals = includeTotals;
        return this;
    }

    public FluentSalesReportBuilder WithOrientation(string orientation)
    {
        _report.Orientation = orientation;
        return this;
    }

    public FluentSalesReportBuilder WithPageSize(string pageSize)
    {
        _report.PageSize = pageSize;
        return this;
    }

    public FluentSalesReportBuilder WithPageNumbers(bool includePageNumbers)
    {
        _report.IncludePageNumbers = includePageNumbers;
        return this;
    }

    public FluentSalesReportBuilder WithCompanyLogo(string companyLogo)
    {
        _report.CompanyLogo = companyLogo;
        return this;
    }

    public FluentSalesReportBuilder WithWaterMark(string waterMark)
    {
        _report.WaterMark = waterMark;
        return this;
    }

    public SalesReport Build()
    {
        return _report;
    }
}