using Spectre.Console;


// Инфа о системе


// ОСь (я кстати арч юзаю)
var osvar = File.ReadLines("/etc/os-release")
    .FirstOrDefault(line => line.StartsWith("PRETTY_NAME"))
    ?.Split('=')[1].Trim().Replace("\"", "");

// Процик
var cpuvar = File.ReadLines("/proc/cpuinfo")
    .FirstOrDefault(line => line.StartsWith("model name"))
    ?.Split(':')[1].Trim();

// Ядра
var coresvar = File.ReadLines("/proc/cpuinfo")
    .FirstOrDefault(line => line.StartsWith("cpu cores"))
    ?.Split(':')[1].Trim();

// Потоки
var potokivar = Environment.ProcessorCount;

// Опра
var kb  = File.ReadLines("/proc/meminfo").First(l => l.StartsWith("MemTotal")).Split(' ', StringSplitOptions.RemoveEmptyEntries)[1];
var ramvar = $"{long.Parse(kb) / 1024.0 / 1024.0:F2} GiB";

// Хост (модель материнки/ноута)
var hostvar = File.ReadAllText("/sys/devices/virtual/dmi/id/product_name").Trim();

// Ядро
var krnlvar = File.ReadAllText("/proc/sys/kernel/osrelease").Trim();

// Шелл
var shellvar = Path.GetFileName(Environment.GetEnvironmentVariable("SHELL"));

// Язык
var localevar = Path.GetFileName(Environment.GetEnvironmentVariable("LANG"));

// Имя пользователя и имя ОС
var username = Environment.UserName;
var machinename = Environment.MachineName;


// Вывод
string kfoutput = $"""
⠀⠀⠀⠀⠀⠀⠀⠀[bold LightSalmon3_1]⣠⣄⠀[/]            {username}@{machinename}
⠀⠀⠀⠀⠀⠀⠀⠀[bold LightSalmon3_1]⠻⡿⠆[/]            ───────────────────────────────────
⠀⠀⠀⠀⠀⠀⠀⠀⠀[bold LightSalmon3_1]⢘⣿⡀[/]           [bold LightSalmon3_1]ОСь:[/] {osvar}
⠀⠀⠀⠀⠀⠀⠀⠀⠀[bold LightSalmon3_1]⢀⠿⠥⠤⠀⡀[/]        [bold LightSalmon3_1]Ядро:[/] {krnlvar}
⠀⠀⠀⠀⠀⠀⠀[bold LightSalmon3_1]⡠⡄⣤⠀⠀⠀⢀⠃⣷⡄[/]      [bold LightSalmon3_1]Хост:[/] {hostvar}
⠀⠀⠀⠀⠀⠀[bold LightSalmon3_1]⠠⠀⠆⠀⠀⠐⠀⠈⠀⠨⠂⡄[/]     [bold LightSalmon3_1]Проц:[/] {cpuvar} Ядер: {coresvar} Потоков: {potokivar}
⠀⠀⠀⠀⠀[bold LightSalmon3_1]⠀⠚⠀⠠⠀⠀⠀⠀⢀⠀⠈⠐⣠⠀[/]    [bold LightSalmon3_1]Оператива:[/] {ramvar}
⠀⠀⠀⠀⠀[bold LightSalmon3_1]⠐⠀⠀⠀⠂⠀⠀⡀⠀⠀⠂⢁⢊⡅[/]    [bold LightSalmon3_1]Локаль:[/] {localevar}
⠀⠀⠀⠀[bold LightSalmon3_1]⢀⠉⠀⠀⠀⠀⠀⠀⠀⠀⠄⠀⠂⡐⢼⡀[/]
⠀⠀⠀⠀[bold LightSalmon3_1]⠂⠀⠀⠀⠂⠀⠀⣆⠀⠀⠀⠈⠄⠀⡔⣣[/]   
⠀⠀⠀[bold LightSalmon3_1]⡡⠊⢆⠀⡀⠀⠀⡇⠈⠣⡀⠀⠀⠡⠀⠌⠐⣣[/]
⠀[bold LightSalmon3_1]⡐⣬⢑⡅⢊⢎⣛⢬⡅⢧⠡⣂⣀⣄⠀⠈⠠⠈⠠⢘⢧[/]
[bold LightSalmon3_1]⢀⢱⡖⣍⣿⣧⠀⠣⣧⠓⠀⡜⣅⣿⣿⣧⢀⠐⠀⠂⢤⠭⡂[/]
[bold LightSalmon3_1]⠠⠸⢇⠻⣿⡟⠂⠀⠘⢷⠀⠈⢿⣿⡿⡻⡉⠄⡁⠀⢀⠨⡆[/]
[bold LightSalmon3_1]⠨⠀⠀⠀⠀⠀⠀⠐⠀⠀⠀⠀⠀⠀⠈⠀⠣⠀⠄⠐⠀⢁⡂[/]
[bold LightSalmon3_1]⠈⡀⠀⠀⠀⠀⠀⢤⣀⣀⣠⠆⠀⠀⠀⠀⠁⠐⠌⠄⡠⢷⠃[/]
⠀[bold LightSalmon3_1]⠐⡠⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⠁⠀⡃⠠⣂⢢⡜[/]
⠀⠀[bold LightSalmon3_1]⠈⢄⠁⢀⠀⡀⠀⠀⡀⠀⠠⠀⠀⠀⡠⠀⢁⢒⠈[/]
⠀⠀⠀⠀[bold LightSalmon3_1]⠐⠠⡀⠂⠈⠄⠀⣀⠀⠈⢂⠈⠠⡰⠖⠁[/]
⠀⠀⠀⠀⠀⠀⠀[bold LightSalmon3_1]⠉⠛⠷⣶⢾⣼⣧⡿⠷⠋⠁[/]
""";

AnsiConsole.MarkupLine(kfoutput);

