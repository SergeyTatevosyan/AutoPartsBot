using AutoPartsBot.Handlers;
using AutoPartsBot.Sevices;
using Telegram.Bot;

var builder = WebApplication.CreateBuilder(args);

// Telegram token
var botToken = builder.Configuration["TelegramBotToken"];
if (string.IsNullOrWhiteSpace(botToken))
    throw new InvalidOperationException("TelegramBotToken не задан в конфигурации!");

// Telegram Bot Client
builder.Services.AddSingleton<ITelegramBotClient>(_ => new TelegramBotClient(botToken));

// Обработчик обновлений
builder.Services.AddSingleton<MessageHandler>();
builder.Services.AddSingleton<CallbackQueryHandler>();
builder.Services.AddSingleton<ITelegramUpdateHandler, TelegramUpdateRouter>();

// Hosted service для long polling
builder.Services.AddHostedService<TelegramBotService>();

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();