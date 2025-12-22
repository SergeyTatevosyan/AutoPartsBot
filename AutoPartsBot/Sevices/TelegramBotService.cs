using AutoPartsBot.Handlers;
using Telegram.Bot;

namespace AutoPartsBot.Sevices;

/// <summary>
/// Сервис для запуска Telegram Bot через Long Polling
/// </summary>
public sealed class TelegramBotService : IHostedService
{
    private readonly ITelegramBotClient _botClient;
    private readonly ITelegramUpdateHandler _updateHandler;
    private CancellationTokenSource? _cts;

    public TelegramBotService(ITelegramBotClient botClient, ITelegramUpdateHandler updateHandler)
    {
        _botClient = botClient;
        _updateHandler = updateHandler;
    }

    public Task StartAsync(CancellationToken cancellationToken)
    {
        _cts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);

        Console.WriteLine("Telegram Bot is running (long polling)...");

        _botClient.StartReceiving(
            async (client, update, token) =>
            {
                try
                {
                    await _updateHandler.HandleAsync(update, token);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка в обработчике обновления: {ex}");
                }
            },
            async (client, exception, source, token) =>
            {
                Console.WriteLine($"Ошибка Telegram API: {exception} (source: {source})");
            },
            receiverOptions: null,
            cancellationToken: _cts.Token
        );

        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        if (_cts is not null)
        {
            _cts.Cancel();
            Console.WriteLine("Stopping Telegram Bot...");
        }
        return Task.CompletedTask;
    }
}