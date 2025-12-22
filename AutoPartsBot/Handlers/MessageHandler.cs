using AutoPartsBot.DAL.Seeding;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

namespace AutoPartsBot.Handlers;

/// <summary>
/// Обрабатывает текстовые сообщения и команды Telegram
/// </summary>
public sealed class MessageHandler : ITelegramUpdateHandler
{
    private readonly ITelegramBotClient _botClient;

    public MessageHandler(ITelegramBotClient botClient)
    {
        _botClient = botClient;
    }

    public async Task HandleAsync(Update update, CancellationToken cancellationToken)
    {
        var message = update.Message!;
        var chatId = message.Chat.Id;

        // Кнопка /start всегда под рукой
        var mainKeyboard = new ReplyKeyboardMarkup(new[]
        { new KeyboardButton[] { "/start" } })
        {
            ResizeKeyboard = true,
            OneTimeKeyboard = false
        };

        if (message.Text?.StartsWith("/start") == true)
        {
            var welcomeText =
                "👋 Привет!\n\n" +
                "Я помогу подобрать качественную запчасть — проверенный аналог заводской (оригинальной) детали, " +
                "который почти не уступает оригиналу по надёжности и комфорту, " +
                "но при этом позволяет сэкономить деньги.\n\n" +
                "Выбери узел автомобиля:";

            await _botClient.SendMessage(
                chatId,
                welcomeText,
                replyMarkup: BuildMainMenu(), // inline-кнопки выбора узлов
                cancellationToken: cancellationToken
            );

            //await _botClient.SendMessage(
            //    chatId,
            //    " ", // пустое сообщение, просто для показа кнопки
            //    replyMarkup: BuildStartReplyKeyboard(),
            //    cancellationToken: cancellationToken
            //);
        }

        return;
    }

    ///// <summary>
    ///// Создает постоянную кнопку /start под строкой ввода сообщений
    ///// </summary>
    //public static ReplyKeyboardMarkup BuildStartReplyKeyboard()
    //{
    //    return new ReplyKeyboardMarkup(new[]
    //    {
    //        new KeyboardButton[] { "/start" }
    //    })
    //    {
    //        ResizeKeyboard = true,
    //        OneTimeKeyboard = false
    //    };
    //}

    /// <summary>
    /// Создает inline-кнопки для выбора узлов автомобиля
    /// </summary>
    public static InlineKeyboardMarkup BuildMainMenu()
    {
        var buttons = InMemoryCarPartsCatalog.Data
            .Select(kvp => InlineKeyboardButton.WithCallbackData(kvp.Value.NodeTitle, $"node:{kvp.Key}"))
            .ToList();

        // Разбиваем на строки по 2 кнопки
        var rows = new List<InlineKeyboardButton[]>();
        for (int i = 0; i < buttons.Count; i += 2)
        {
            if (i + 1 < buttons.Count)
                rows.Add(new[] { buttons[i], buttons[i + 1] });
            else
                rows.Add(new[] { buttons[i] });
        }

        return new InlineKeyboardMarkup(rows);
    }
}