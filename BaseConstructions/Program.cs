using BaseConstructions.TasksClasses;
string choice;
do
{
    Console.Clear();
    Console.WriteLine("Выберите задание \n1.Симметричная ли матрица? " +
        "\n2.Противоположные элементы " +
        "\n3.Температура на улице - локальные максимумы и минимумы " +
        "\n4.Выход");
    choice = Console.ReadLine();

    switch(choice)
    {
        case "1": IsMatrixSymmetric.Start(); break;
        case "2": OppositeElements.Start(); break;
        case "3": Temperature.Start(); break;
    }

    if (choice != "4")
    {
        Console.WriteLine("Нажмите любую клавишу для продолжения");
        Console.ReadKey();
    }
} while (choice != "4");
Console.Clear();
Console.WriteLine("Ну бб(");