namespace SharedKernel;

public sealed record PaginatedOutput<T>(IEnumerable<T> Items, int Total);
