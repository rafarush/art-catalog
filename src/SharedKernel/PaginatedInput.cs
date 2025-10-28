namespace SharedKernel;

public class PaginatedInput()
{
    public string OffsetField { get; set; }

    public required int OffsetPage { get; set; }

    public required int Limit { get; set; }
    public bool HasPagination { get; set; } = true;
    public bool IsAsc { get; set; }

    public virtual bool IsOffsetFieldValid() => true;
};
