namespace AutoPartsBot.DAL.Seeding;

/// <summary>
/// In-memory каталог брендов по узлам автомобиля
/// </summary>
public static class InMemoryCarPartsCatalog
{
    public static readonly IReadOnlyDictionary<CarNodeType, CarNodeBrands> Data =
        new Dictionary<CarNodeType, CarNodeBrands>
        {
            {
                CarNodeType.Brakes,
                new CarNodeBrands {
                    NodeTitle = "🛑 Детали тормозов",
                    Brands = new[] {
                        new Brand
                        {
                            Name = "ATE",
                            Country = "Германия",
                            Description = "Исторический бренд тормозных систем с 1950-х. Поставляет оригинальные тормозные компоненты для VW, Audi, BMW и Mercedes. Признан как надежный OEM-поставщик для европейских автомобилей."
                        },
                        new Brand
                        {
                            Name = "Textar",
                            Country = "Германия",
                            Description = "Входит в TMD Friction. Оригинальный поставщик тормозных колодок для немецких автозаводов, проверено десятилетиями. Бренд специализируется на тормозных колодках с середины XX века."
                        },
                        new Brand
                        {
                            Name = "TRW",
                            Country = "Германия",
                            Description = "Часть ZF Group. Лидер в производстве систем активной безопасности и тормозных комплектов для OEM-рынка. Поставляет тормозные системы и компоненты для VW, Mercedes и других европейских брендов."
                        },
                        new Brand
                        {
                            Name = "Brembo",
                            Country = "Италия",
                            Description = "Мировой эталон в тормозных системах. Поставляет комплектующие для Formula 1, суперкаров и премиальных автомобилей. История бренда в производстве тормозных систем насчитывает несколько десятилетий."
                        },
                        new Brand
                        {
                            Name = "Ferodo",
                            Country = "Великобритания",
                            Description = "Один из старейших брендов фрикционных материалов, с 1897 года производит колодки и тормозные накладки для легковых и грузовых авто. Поставщик для многих европейских OEM."
                        },
                        new Brand
                        {
                            Name = "Zimmerman",
                            Country = "Германия",
                            Description = "Надежный производитель тормозных дисков и колодок, поставщик для многих европейских OEM-производителей, включая VW, Audi, BMW."
                        }
                    }
                }
            },
            {
                CarNodeType.EngineECU,
                new CarNodeBrands {
                    NodeTitle = "💻 Электроника управления двигателем",
                    Brands = new[] {
                        new Brand
                        {
                            Name = "Bosch",
                            Country = "Германия",
                            Description = "Один из крупнейших мировых производителей электронных систем управления двигателем с начала 20 века. Поставляет оригинальные ECU и датчики для VW, BMW, Mercedes, Audi и многих других европейских OEM-производителей."
                        },
                        new Brand
                        {
                            Name = "Siemens VDO / Continental",
                            Country = "Германия",
                            Description = "Исторический разработчик ECU и датчиков. Входит в состав Continental, поставляет электронные блоки для немецких OEM."
                        },
                        new Brand
                        {
                            Name = "Denso",
                            Country = "Япония",
                            Description = "Ведущий японский разработчик систем управления двигателем и датчиков. Поставляет ECU и компоненты для Toyota, Lexus, Honda и других азиатских OEM. История бренда — с 1949 года."
                        },
                        new Brand
                        {
                            Name = "Valeo",
                            Country = "Франция",
                            Description = "Глобальный поставщик электронных систем для автомобилей. Поставляет ECU, датчики и блоки управления для европейских OEM, включая Renault, Peugeot, Mercedes и BMW."
                        }
                    }
                }
            },
            {
                CarNodeType.SuspensionSteering,
                new CarNodeBrands {
                    NodeTitle = "🚜 Подвеска и рулевое управление",
                    Brands = new[] {
                        new Brand
                        {
                            Name = "Lemförder",
                            Country = "Германия",
                            Description = "Премиум-бренд группы ZF. Поставляет детали подвески и рулевого управления для многих европейских OEM-производителей, включая VW, BMW и Mercedes. Известен высоким качеством сайлентблоков и рычагов."
                        },
                        new Brand
                        {
                            Name = "Febi Bilstein",
                            Country = "Германия",
                            Description = "Старейший бренд Bilstein Group, специализирующийся на сайлентблоках, подушках подвески и рулевого управления. Поставляет компоненты на конвейеры европейских OEM."
                        },
                        new Brand
                        {
                            Name = "Sachs",
                            Country = "Германия",
                            Description = "Один из крупнейших производителей амортизаторов и пружин для легковых и коммерческих автомобилей. Поставщик оригинальных компонентов для VW, BMW, Mercedes с 1895 года."
                        },
                        new Brand
                        {
                            Name = "KYB",
                            Country = "Япония",
                            Description = "Мировой лидер по производству амортизаторов и подвески. Поставляет компоненты для Toyota, Honda, Lexus, Nissan."
                        },
                        new Brand
                        {
                            Name = "Bilstein",
                            Country = "Германия",
                            Description = "С 1873 года производит газонаполненные амортизаторы. Используется как в OEM, так и в гоночных системах подвески."
                        },
                        new Brand
                        {
                            Name = "Monroe",
                            Country = "США",
                            Description = "Один из крупнейших производителей амортизаторов и комплектов подвески для легковых и коммерческих автомобилей. С 1916 года поставляет оригинальные компоненты для многих OEM-производителей, включая Ford, GM и European OEM."
                        },
                        new Brand
                        {
                            Name = "Lesjöfors",
                            Country = "Швеция",
                            Description = "Старейший производитель пружин и компонентов подвески с 1852 года. Известен долговечностью и точностью производства."
                        }
                    }
                }
            },
            {
                CarNodeType.Filters,
                new CarNodeBrands {
                    NodeTitle = "🌀 Фильтры",
                    Brands = new[] {
                        new Brand {
                            Name = "Mann Filter",
                            Country = "Германия",
                            Description = "Премиальный стандарт фильтрации. Поставляется на конвейеры VAG, BMW, Mercedes и других европейских OEM-производителей."
                        },
                        new Brand {
                            Name = "Mahle",
                            Country = "Германия",
                            Description = "Один из крупнейших производителей систем фильтрации и деталей двигателя, активно поставляет для немецких автозаводов."
                        },
                        new Brand {
                            Name = "Hengst",
                            Country = "Германия",
                            Description = "Надёжный бренд для премиального сегмента, используется как на конвейере, так и в aftermarket."
                        },
                        new Brand {
                            Name = "UFI",
                            Country = "Италия",
                            Description = "Специализируется на фильтрах и охлаждающих системах, поставщик OEM для европейских автомобилей."
                        },
                        new Brand {
                            Name = "Filtron",
                            Country = "Польша",
                            Description = "Бюджетное решение с достойным качеством, входит в группу Mann-Hummel, проверено годами."
                        }
                    }
                }
            },
            {
                CarNodeType.EngineParts,
                new CarNodeBrands {
                    NodeTitle = "⚙️ Детали двигателя",
                    Brands = new[] {
                        new Brand {
                            Name = "Kolbenschmidt",
                            Country = "Германия",
                            Description = "Эксперт в области поршней и гильз цилиндров для тяжелых условий эксплуатации, поставщик OEM для BMW, VW, Audi."
                        },
                        new Brand {
                            Name = "Mahle",
                            Country = "Германия",
                            Description = "Широкий ассортимент деталей двигателя — поршни, кольца, фильтры, поставщик для OEM и aftermarket."
                        },
                        new Brand {
                            Name = "Goetze",
                            Country = "Германия",
                            Description = "Специализируется на высококачественных поршневых кольцах, входит в группу KS Kolbenschmidt."
                        },
                        new Brand {
                            Name = "INA",
                            Country = "Германия",
                            Description = "Мировой лидер в производстве игольчатых подшипников и компонентов ГРМ, поставщик на конвейеры Mercedes, VW и других."
                        },
                        new Brand {
                            Name = "Victor Reinz",
                            Country = "Германия",
                            Description = "Специалист по прокладкам и сальникам, надёжный OEM-поставщик для немецких автозаводов, с историей с 1907 года."
                        },
                        new Brand {
                            Name = "Elring",
                            Country = "Германия",
                            Description = "Производитель прокладок, сальников и компонентов двигателя, поставляет для большинства европейских OEM."
                        },
                        new Brand {
                            Name = "Nural",
                            Country = "Германия",
                            Description = "Производитель поршневых колец и комплектующих с OEM-качеством, проверенный временем."
                        }
                    }
                }
            },
            {
                CarNodeType.CoolingSystem,
                new CarNodeBrands {
                    NodeTitle = "❄️ Система кондиционирования и отопления",
                    Brands = new[] {
                        new Brand {
                            Name = "Behr / Hella / Knecht",
                            Country = "Германия",
                            Description = "Премиальный стандарт в системах климат-контроля, поставляют оригинальные компоненты для BMW, Mercedes, VW."
                        },
                        new Brand {
                            Name = "Denso",
                            Country = "Япония",
                            Description = "Мировой лидер в автомобильной климатике, поставщик оригинальных комплектующих для Toyota, Lexus и других японских брендов."
                        },
                        new Brand {
                            Name = "Valeo",
                            Country = "Франция",
                            Description = "Глобальный производитель систем кондиционирования и отопления, поставляет OEM-компоненты для европейских автозаводов."
                        },
                        new Brand {
                            Name = "Delphi",
                            Country = "Великобритания",
                            Description = "Известный OEM-поставщик кондиционеров и компрессоров, часто устанавливается с завода на Opel, Ford и другие европейские автомобили."
                        },
                        new Brand {
                            Name = "Luzar",
                            Country = "Россия",
                            Description = "Бюджетный и надёжный вариант для замены деталей кондиционера и отопителя, подходит для массового aftermarket."
                        },
                        new Brand {
                            Name = "Nissens",
                            Country = "Дания",
                            Description = "Специалист по радиаторам, конденсаторам и компонентам климатической системы, проверенный поставщик aftermarket."
                        }
                    }
                }
            },
            {
                CarNodeType.CVJoints,
                new CarNodeBrands {
                    NodeTitle = "🔩 ШРУСы и пыльники",
                    Brands = new[] {
                        new Brand {
                            Name = "GKN Spidan",
                            Country = "Германия",
                            Description = "Мировой лидер в области трансмиссий. Поставляет ШРУСы и приводы на конвейеры VW, BMW, Mercedes и других OEM."
                        },
                        new Brand {
                            Name = "SKF",
                            Country = "Швеция",
                            Description = "Высококачественные комплекты приводов и шарниров. Более 100 лет опыта в подшипниках и трансмиссионных системах, активно используется в OEM."
                        },
                        new Brand {
                            Name = "TRW / ZF",
                            Country = "Германия",
                            Description = "Входит в ZF Group. Надежные ШРУСы и приводные элементы, OEM-поставщик для многих европейских производителей."
                        },
                        new Brand {
                            Name = "Lemförder / ZF",
                            Country = "Германия",
                            Description = "Бренд группы ZF. Производит сайлентблоки, подушки и приводные элементы для подвески и трансмиссии, проверено десятилетиями."
                        },
                        new Brand {
                            Name = "Febi / Bilstein Group",
                            Country = "Германия",
                            Description = "Надежные детали подвески и трансмиссии для aftermarket и OEM, присутствует на рынке более 50 лет."
                        },
                        new Brand {
                            Name = "INA / Schaeffler Group",
                            Country = "Германия",
                            Description = "Мировой лидер по подшипникам и комплектующим для трансмиссий. ШРУСы и приводные элементы подходят для OEM и aftermarket."
                        }
                    }
                }
            },
            {
                CarNodeType.Bearings,
                new CarNodeBrands {
                    NodeTitle = "⚙️ Подшипники и роликовые элементы",
                    Brands = new[] {
                        new Brand {
                            Name = "SKF",
                            Country = "Швеция",
                            Description = "Более 100 лет опыта в производстве подшипников. Мировой лидер, поставщик для BMW, VW, Mercedes и других OEM."
                        },
                        new Brand {
                            Name = "INA / Schaeffler Group",
                            Country = "Германия",
                            Description = "Ведущий производитель роликовых и игольчатых подшипников, входит в Schaeffler Group. OEM-поставщик для Audi, BMW, Mercedes."
                        },
                        new Brand {
                            Name = "FAG / Schaeffler Group",
                            Country = "Германия",
                            Description = "Специализируется на подшипниках для трансмиссий и ходовой части, OEM-поставщик для европейских производителей."
                        },
                        new Brand {
                            Name = "Timken",
                            Country = "США",
                            Description = "Более 120 лет опыта в подшипниках и трансмиссионных компонентах. Используется в тяжелой технике и автомобилях премиум-класса."
                        },
                        new Brand {
                            Name = "NSK",
                            Country = "Япония",
                            Description = "Японский производитель подшипников с проверенным качеством для японских OEM, включая Toyota и Honda."
                        },
                        new Brand {
                            Name = "Koyo / JTEKT",
                            Country = "Япония",
                            Description = "Ведущий японский бренд по подшипникам, активно используется в трансмиссиях и ходовой части OEM."
                        },
                        new Brand {
                            Name = "NTN",
                            Country = "Япония",
                            Description = "Производитель подшипников для различных сфер, надежен для aftermarket и OEM."
                        }
                    }
                }
            },
            {
                CarNodeType.Belts,
                new CarNodeBrands {
                    NodeTitle = "🎗️ Ремни и ремкомплекты",
                    Brands = new[] {
                        new Brand {
                            Name = "Gates",
                            Country = "США",
                            Description = "Мировой лидер в производстве ремней и ремкомплектов для OEM и aftermarket, поставляет для VW, BMW, Mercedes и других брендов."
                        },
                        new Brand {
                            Name = "ContiTech / Continental",
                            Country = "Германия",
                            Description = "Высококачественные ремни и комплекты для европейских и азиатских OEM-производителей, проверено десятилетиями."
                        },
                        new Brand {
                            Name = "Mitsuboshi",
                            Country = "Япония",
                            Description = "Японский производитель ремней с проверенным качеством, активно используется в японских OEM."
                        },
                        new Brand {
                            Name = "INA / Schaeffler Group",
                            Country = "Германия",
                            Description = "Входит в Schaeffler Group, поставляет ремкомплекты и ролики для двигателей и ГРМ для европейских OEM."
                        },
                        new Brand {
                            Name = "SKF",
                            Country = "Швеция",
                            Description = "Хотя известен подшипниками, также производит качественные ролики и ремкомплекты для OEM и aftermarket."
                        },
                        new Brand {
                            Name = "Dayco",
                            Country = "Италия",
                            Description = "Популярный бренд ремней и комплектующих, доступный по цене. Проверенное качество для массового рынка, хорошая альтернатива премиум-производителям, но считается бюджетным вариантом."
                        }
                    }
                }
            },
            {
                CarNodeType.ClutchParts,
                new CarNodeBrands {
                    NodeTitle = "🔄 Детали сцепления",
                    Brands = new[] {
                        new Brand {
                            Name = "Sachs",
                            Country = "Германия",
                            Description = "Мировой лидер в производстве сцеплений, поставляет OEM-компоненты для VW, BMW, Mercedes, Audi и других брендов с 1930-х годов."
                        },
                        new Brand {
                            Name = "Luk / Schaeffler Group",
                            Country = "Германия",
                            Description = "Входит в Schaeffler Group, оригинальный поставщик сцеплений и комплектующих для европейских автозаводов."
                        },
                        new Brand {
                            Name = "Valeo",
                            Country = "Франция",
                            Description = "Глобальный производитель сцеплений и комплектующих, поставляет для европейских и азиатских OEM."
                        },
                        new Brand {
                            Name = "Exedy",
                            Country = "Япония",
                            Description = "Проверенный японский производитель сцеплений для легковых и спортивных автомобилей, OEM-поставщик для японских брендов."
                        },
                        new Brand {
                            Name = "FTE",
                            Country = "Германия",
                            Description = "Надежный производитель гидравлических компонентов сцепления и сцеплений для aftermarket и OEM."
                        }
                    }
                }
            },
            {
                CarNodeType.WaterPumps,
                new CarNodeBrands {
                    NodeTitle = "💧 Водяные насосы / помпы",
                    Brands = new[] {
                        new Brand {
                            Name = "SKF",
                            Country = "Швеция",
                            Description = "Надёжный мировой производитель подшипников и водяных насосов, поставляет OEM-компоненты для большинства европейских автопроизводителей."
                        },
                        new Brand {
                            Name = "Gates",
                            Country = "США",
                            Description = "Мировой лидер в производстве ремней и водяных насосов, поставляет OEM-компоненты для VW, BMW, Mercedes и других брендов."
                        },
                        new Brand {
                            Name = "Behr / Hella",
                            Country = "Германия",
                            Description = "Проверенные немецкие насосы, поставляются как оригинальные детали для BMW, Audi и Mercedes."
                        },
                        new Brand {
                            Name = "INA / Schaeffler Group",
                            Country = "Германия",
                            Description = "Надёжный производитель помп для двигателей, входит в Schaeffler Group, поставляет OEM для европейских автозаводов."
                        },
                        new Brand {
                            Name = "Dayco",
                            Country = "Италия",
                            Description = "Проверенный бренд ремней и помп, доступный по цене и с хорошим качеством для массового рынка."
                        },
                        new Brand {
                            Name = "Metelli",
                            Country = "Италия",
                            Description = "Надёжный итальянский производитель водяных насосов и комплектующих, подходит для aftermarket. Не премиум, но долговечный и доступный вариант."
                        }
                    }
                }
            },
            {
                CarNodeType.Gaskets,
                new CarNodeBrands {
                    NodeTitle = "🩹 Прокладки и сальники",
                    Brands = new[] {
                        new Brand {
                            Name = "Victor Reinz",
                            Country = "Германия",
                            Description = "Мировой лидер в производстве прокладок и сальников для двигателя, поставляет OEM-компоненты для BMW, Mercedes, VW с 1907 года. Премиум-качество для европейских автомобилей."
                        },
                        new Brand {
                            Name = "Elring",
                            Country = "Германия",
                            Description = "Надёжный производитель прокладок и комплектующих двигателя, поставляет детали для большинства европейских автопроизводителей. Качество чуть ниже премиум, но стабильно."
                        },
                        new Brand {
                            Name = "Mahle",
                            Country = "Германия",
                            Description = "Высококачественные прокладки и уплотнения, известен надежностью и долговечностью. Хороший средний сегмент для OEM и aftermarket."
                        },
                        new Brand {
                            Name = "Fel-Pro",
                            Country = "США",
                            Description = "Популярный американский бренд, средний сегмент. Доступная цена при достойном качестве для легковых и грузовых автомобилей."
                        },
                        new Brand {
                            Name = "Payen",
                            Country = "Франция",
                            Description = "Бюджетный, но надёжный европейский вариант для замены прокладок и сальников. Качество хорошее для массового aftermarket."
                        }
                    }
                }
            },
            {
                CarNodeType.IgnitionSystem,
                new CarNodeBrands {
                    NodeTitle = "🔥 Система зажигания",
                    Brands = new[] {
                        new Brand {
                            Name = "NGK",
                            Country = "Япония",
                            Description = "Мировой лидер по свечам зажигания и датчикам детонации, поставляет компоненты для Toyota, Honda, Nissan и европейских OEM."
                        },
                        new Brand {
                            Name = "Denso",
                            Country = "Япония",
                            Description = "Ведущий японский производитель свечей и компонентов системы зажигания, OEM-поставщик для Toyota, Lexus и Honda."
                        },
                        new Brand {
                            Name = "Bosch",
                            Country = "Германия",
                            Description = "Надёжные свечи, катушки и датчики для европейских и американских автомобилей, поставщик оригинальных комплектующих для BMW, VW, Mercedes."
                        },
                        new Brand {
                            Name = "Beru",
                            Country = "Германия",
                            Description = "Исторический бренд свечей и компонентов системы зажигания, используется в премиальных и грузовых автомобилях."
                        }
                    }
                }
            },
            {
                CarNodeType.StartersGenerators,
                new CarNodeBrands {
                    NodeTitle = "⚡ Стартеры и генераторы",
                    Brands = new[] {
                        new Brand { Name = "Bosch", Country = "Германия", Description = "Мировой лидер в стартерных и генераторных системах, поставляет оригинальные компоненты для VW, BMW, Mercedes." },
                        new Brand { Name = "Valeo", Country = "Франция", Description = "Поставляет стартеры и генераторы на конвейеры европейских автозаводов, надежный OEM-поставщик." },
                        new Brand { Name = "Denso", Country = "Япония", Description = "Высококачественные стартеры и генераторы для японских автомобилей, долговечные и проверенные временем." },
                        new Brand { Name = "Mitsubishi Electric", Country = "Япония", Description = "Производит надежные стартеры и генераторы для OEM-рынка, в том числе для европейских и японских брендов." },
                        new Brand { Name = "Hitachi", Country = "Япония", Description = "Надежные электрические компоненты, включая стартеры и генераторы, проверенные на долгий срок службы." }
                    }
                }
            },
            {
                CarNodeType.Batteries,
                new CarNodeBrands {
                    NodeTitle = "🔋 Аккумуляторы",
                    Brands = new[] {
                        new Brand { Name = "Varta", Country = "Германия", Description = "Надёжные аккумуляторы для европейских автомобилей, OEM-поставщик для BMW, VW, Mercedes." },
                        new Brand { Name = "Bosch", Country = "Германия", Description = "Качественные аккумуляторы с долгим сроком службы, известный OEM-поставщик." },
                        new Brand { Name = "Banner", Country = "Австрия", Description = "Надёжные аккумуляторы премиум-класса, поставляются для OEM-рынка и aftermarket." },
                        new Brand { Name = "Exide", Country = "США", Description = "Мировой лидер в производстве аккумуляторов, надёжные решения для легковых и коммерческих авто." },
                        new Brand { Name = "Yuasa", Country = "Япония", Description = "Высококачественные аккумуляторы для японских и европейских автомобилей." }
                    }
                }
            },
            {
            CarNodeType.Oils,
                new CarNodeBrands {
                    NodeTitle = "🧴 Масла и смазочные материалы",
                    Brands = new[] {
                        new Brand {
                            Name = "Mobil 1",
                            Country = "США",
                            Description = "Премиальные синтетические масла, проверенные временем на надежность и стабильность характеристик."
                        },
                        new Brand {
                            Name = "Liqui Moly",
                            Country = "Германия",
                            Description = "Немецкий производитель моторных и трансмиссионных масел, проверенный OEM-поставщик."
                        },
                        new Brand {
                            Name = "Castrol",
                            Country = "Великобритания",
                            Description = "Мировой лидер по моторным и трансмиссионным маслам, OEM-поставщик для BMW, VW, Ford."
                        },
                        new Brand {
                            Name = "Shell",
                            Country = "Великобритания/Нидерланды",
                            Description = "Качественные масла для легковых и коммерческих автомобилей, поставщик европейских автозаводов."
                        },
                        new Brand {
                            Name = "Petronas",
                            Country = "Малайзия",
                            Description = "Современные синтетические масла для двигателей и трансмиссий, OEM-поставщик для премиальных марок."
                        },
                        new Brand {
                            Name = "Bardahl",
                            Country = "США",
                            Description = "Надёжные масла и присадки, проверенные временем на массовом рынке."
                        },
                        new Brand {
                            Name = "Febi Bilstein",
                            Country = "Германия",
                            Description = "Специализируется на трансмиссионных жидкостях и смазках для узлов подвески и трансмиссии."
                        }
                    }
                }
            },
            {
                CarNodeType.Optics,
                new CarNodeBrands {
                    NodeTitle = "👁️ Оптика",
                    Brands = new[] {
                        new Brand {
                            Name = "Hella",
                            Country = "Германия",
                            Description = "Один из крупнейших мировых производителей фар и светотехники, поставляет на конвейеры BMW, VW, Mercedes."
                        },
                        new Brand {
                            Name = "Valeo",
                            Country = "Франция",
                            Description = "OEM-поставщик для европейских автозаводов, известен качественными фарами и задними фонарями."
                        },
                        new Brand {
                            Name = "Bosch",
                            Country = "Германия",
                            Description = "Проверенный бренд в электрооптике, производитель головной и дополнительной светотехники."
                        },
                        new Brand {
                            Name = "Magneti Marelli",
                            Country = "Италия",
                            Description = "Долгие годы поставляет оптику для итальянских и европейских автомобилей."
                        }
                    }
                }
            },
            {
                CarNodeType.Lamps,
                new CarNodeBrands {
                    NodeTitle = "💡 Лампы",
                    Brands = new[] {
                        new Brand {
                            Name = "Osram",
                            Country = "Германия",
                            Description = "Один из старейших и крупнейших производителей автомобильных ламп, поставляет на конвейеры BMW, Audi, Mercedes с 1906 года."
                        },
                        new Brand {
                            Name = "Philips",
                            Country = "Нидерланды",
                            Description = "Проверенный OEM-поставщик, производитель галогенных, ксеноновых и LED ламп для европейских и азиатских автомобилей."
                        },
                        new Brand {
                            Name = "Hella",
                            Country = "Германия",
                            Description = "Поставщик светотехники для премиальных европейских автомобилей, известен долговечностью и качеством света."
                        },
                        new Brand {
                            Name = "Narva",
                            Country = "Германия",
                            Description = "Надёжный европейский бренд для aftermarket, часто используется как OEM-замена, качество сравнимо с Osram."
                        },
                        new Brand {
                            Name = "Bosch",
                            Country = "Германия",
                            Description = "Производитель ламп и электроники освещения для OEM и aftermarket, проверенное качество."
                        }
                    }
                }
            },
            {
                CarNodeType.Wipers,
                new CarNodeBrands {
                    NodeTitle = "🧹 Щетки стеклоочистителя",
                    Brands = new[] {
                        new Brand {
                            Name = "SWF / Valeo",
                            Country = "Германия",
                            Description = "Поставляет оригинальные щетки на европейские конвейеры (VAG, BMW, Mercedes). Надёжность проверена десятилетиями."
                        },
                        new Brand {
                            Name = "Bosch",
                            Country = "Германия",
                            Description = "Мировой лидер в производстве щеток, долговечные и эффективные, OEM и aftermarket."
                        },
                        new Brand {
                            Name = "Denso",
                            Country = "Япония",
                            Description = "Поставляет щетки на японские автомобили (Toyota, Lexus, Honda), высокая надёжность и долговечность."
                        },
                        new Brand {
                            Name = "Champion",
                            Country = "США",
                            Description = "Более доступный вариант, часто используется как aftermarket-замена."
                        }
                    }
                }
            }
        };
}