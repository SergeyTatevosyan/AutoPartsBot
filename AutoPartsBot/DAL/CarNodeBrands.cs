namespace AutoPartsBot.DAL;

/// <summary>
/// Узел автомобиля с перечнем рекомендуемых брендов
/// </summary>
public sealed record CarNodeBrands
{
    /// <summary>
    /// Отображаемое название узла
    /// </summary>
    public required string NodeTitle { get; init; }

    /// <summary>
    /// Список проверенных брендов для узла
    /// </summary>
    public required IReadOnlyCollection<Brand> Brands { get; init; }
}