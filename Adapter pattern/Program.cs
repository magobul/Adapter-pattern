using Adapter_pattern;

class Program
{
    static void Main(string[] args)
    {
        ComputerGame game = new ComputerGame
        (
            "Смута",
            PegiAgeRating.P18,
            1000,
            4096,
            50, 
            16,
            4, // Необходимое количество ядер
            3.5 // Скорость ядра в ГГц
        );

        PCGame adaptedGame = new ComputerGameAdapter(game);

        Console.WriteLine($"Название: {adaptedGame.getTitle()}");
        Console.WriteLine($"Разрешенный возраст: {adaptedGame.getPegiAllowedAge()}");
        Console.WriteLine($"Is Triple A Game: {adaptedGame.isTripleAGame()}");

        Requirements requirements = adaptedGame.getRequirements();
        Console.WriteLine($"Минимальная память GPU: {requirements.getGpuGb()} GB");
        Console.WriteLine($"Нужное дисковое пространство: {requirements.getHDDGb()} GB");
        Console.WriteLine($"Необходимая оперативная память: {requirements.getRAMGb()} GB");
        Console.WriteLine($"Скорость ядра: {requirements.getCpuGhz()} GHz");
        Console.WriteLine($"Необходимое количество ядер: {requirements.getCoresNum()}");
    }
}