namespace AutoPartsBot.Handlers;
using Telegram.Bot.Types;

/// <summary>
/// Контракт обработчика входящих обновлений Telegram
/// </summary>
public interface ITelegramUpdateHandler
{
    /// <summary>
    /// Обрабатывает входящее обновление Telegram (сообщение, callback, команду и т.д.)
    /// </summary>
    /// <param name="update">Обновление от Telegram</param>
    /// <param name="cancellationToken">Токен отмены</param>
    Task HandleAsync(Update update, CancellationToken cancellationToken);
}