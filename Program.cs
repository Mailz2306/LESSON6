
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.InputFiles;

TelegramBotClient client = new TelegramBotClient("fgfjhgfdjhgf_bot"); 

User user = await client.GetMeAsync();

Console.WriteLine(user.Username); 

