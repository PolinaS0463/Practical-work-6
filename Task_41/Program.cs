Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] fillArrayWithInput(int size){
    int[] array = new int[size];
    for(int index = 0; index < array.Length; index++){
        Console.Write($"Введите {index + 1}-й элемент массива: ");
        int num = Convert.ToInt32(Console.ReadLine());
        array[index] = num;
    }
    return array;
}

int[] result = fillArrayWithInput(size);
Console.WriteLine(string.Join(", ", result));

int findNumsMoreThanZero(int[] array){
    int count = 0;
    foreach(int num in array){
        if (num > 0){
            count += 1;
        }
    }
    return count;
}

int amount = findNumsMoreThanZero(result);

Console.WriteLine($"В целочисленном массиве [{string.Join(", ", result)}] {amount} чисел(ла) больше нуля");