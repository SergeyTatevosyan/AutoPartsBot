using Telegram.Bot.Types;

namespace AutoPartsBot.Handlers;

/// <summary>
/// Роутер входящих обновлений Telegram
/// </summary>
public sealed class TelegramUpdateRouter : ITelegramUpdateHandler
{
    private readonly MessageHandler _messageHandler;
    private readonly CallbackQueryHandler _callbackQueryHandler;

    public TelegramUpdateRouter(
        MessageHandler messageHandler,
        CallbackQueryHandler callbackQueryHandler)
    {
        _messageHandler = messageHandler;
        _callbackQueryHandler = callbackQueryHandler;
    }

    public async Task HandleAsync(Update update, CancellationToken cancellationToken)
    {
        if (update.Message is not null)
        {
            await _messageHandler.HandleAsync(update, cancellationToken);
            return;
        }

        if (update.CallbackQuery is not null)
        {
            await _callbackQueryHandler.HandleAsync(update, cancellationToken);
        }
    }
}