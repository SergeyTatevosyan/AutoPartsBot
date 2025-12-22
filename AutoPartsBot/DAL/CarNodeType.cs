namespace AutoPartsBot.DAL;

/// <summary>
/// Тип узла в каталоге автозапчастей
/// </summary>
public enum CarNodeType
{
    Brakes,             // Детали тормозов
    EngineECU,          // Электроника управления двигателем
    SuspensionSteering, // Подвеска и рулевое управление
    Filters,            // Фильтры
    AirConditioning,    // Детали системы кондиционирования и отопления
    EngineParts,        // Детали двигателя
    Springs,            // Пружины подвески
    Bearings,           // Подшипники
    CVJoints,           // ШРУСы и пыльники
    Belts,              // Ремни и ремкомплекты
    ShockAbsorbers,     // Амортизаторы и отбойники
    Lamps,              // Лампы
    CoolingSystem,      // Система кондиционирования и отопления
    ClutchParts,        // Детали сцепления
    WaterPumps,         // Водяные насосы
    Gaskets,            // Прокладки и сальники
    IgnitionSystem,     // Система зажигания
    Sensors,            // Детали электронных систем, датчики
    ExhaustSystem,      // Детали выхлопной системы
    Optics,             // Оптика
    StartersGenerators, // Стартеры и генераторы
    Oils,               // Масла и смазочные материалы
    Batteries,          // Аккумуляторы
    TowBars,            // Фаркопы
    RubberMetal,        // Резинометалика
    Wipers,             // Щетки стеклоочистителя
    Tensioners,         // Натяжители, гасители, муфты
    Hoses,              // Шланги и патрубки
    Electronics,        // Электрика и электроника
    ComfortElectronics, // Комфорт-электроника
    FuelSystem,         // Топливная система
    EmissionControl,    // Система контроля токсичности
    ACService           // Установки для обслуживания кондиционеров
}