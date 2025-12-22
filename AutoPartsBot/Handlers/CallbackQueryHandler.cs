using AutoPartsBot.DAL;
using AutoPartsBot.DAL.Seeding;
using Telegram.Bot;
using Telegram.Bot.Requests;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace AutoPartsBot.Handlers;

/// <summary>
/// Обрабатывает нажатия на inline-кнопки Telegram
/// </summary>
public sealed class CallbackQueryHandler : ITelegramUpdateHandler
{
    private readonly ITelegramBotClient _botClient;

    public CallbackQueryHandler(ITelegramBotClient botClient)
    {
        _botClient = botClient;
    }

    /// <inheritdoc />
    public async Task HandleAsync(Update update, CancellationToken cancellationToken)
    {
        if (update.CallbackQuery is not { Data: { } data })
            return;

        var chatId = update.CallbackQuery.Message!.Chat.Id;

        if (data == "mainmenu")
        {
            // Отправляем главное меню заново
            await _botClient.SendMessage(
                chatId,
                "Выбери узел автомобиля:",
                replyMarkup: MessageHandler.BuildMainMenu(),
                cancellationToken: cancellationToken
            );
            return;
        }

        if (!data.StartsWith("node:"))
            return;

        var nodeValue = data.Replace("node:", string.Empty);

        if (!Enum.TryParse<CarNodeType>(nodeValue, out var nodeType))
            return;

        var nodeData = InMemoryCarPartsCatalog.Data[nodeType];

        var text =
            $"🔧 *{nodeData.NodeTitle}*\n\n" +
            string.Join("\n\n", nodeData.Brands.Select(b =>
                $"• *{b.Name}* ({b.Country})\n_{b.Description}_"));

        // Кнопка возврата в главное меню
        var keyboard = new InlineKeyboardMarkup(new[]
        {
            new[]
            {
                InlineKeyboardButton.WithCallbackData("⬅️ Вернуться к выбору узла", "mainmenu")
            }
        });

        await _botClient.SendRequest(
            new SendMessageRequest
            {
                ChatId = new ChatId(update.CallbackQuery.Message!.Chat.Id),
                Text = text,
                ParseMode = ParseMode.Markdown,
                ReplyMarkup = keyboard
            },
            cancellationToken
        );
    }
}