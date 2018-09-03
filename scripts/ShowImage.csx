var bytes = File.ReadAllBytes("images/Chinjung.png");
var base64 = Convert.ToBase64String(bytes);
Console.Write($"\u001B]1337;File=;inline=1:{base64}\u0007");