namespace AutoPartsBot.DAL;

/// <summary>
/// Производитель автозапчасти
/// </summary>
public sealed record Brand
{
    /// <summary>
    /// Название бренда
    /// </summary>
    public required string Name { get; init; }

    /// <summary>
    /// Страна происхождения бренда
    /// </summary>
    public required string Country { get; init; }

    /// <summary>
    /// Краткое описание и история бренда
    /// </summary>
    public string? Description { get; init; }
}