using System;
using System.ComponentModel;
using System.Diagnostics;

List<int> Data = new List<int>();
List<int> Data1 = new List<int>();
string In, Input;
do
{

    Console.WriteLine("1.Store Data");
    Console.WriteLine("2.Print ");
    Console.WriteLine("3.Sort ");
    Console.WriteLine("4.Found ");
    Console.WriteLine("5.Search ");
    Console.WriteLine("6.Reverse ");
    Console.WriteLine("7.Maximum");
    Console.WriteLine("8.Minimum");
    Console.WriteLine("9.Average ");
    Console.WriteLine("10.Occurance ");
    Console.WriteLine("11.Median ");
    Console.WriteLine("12.Standard Deviation ");
    Console.WriteLine("13.Unique Values ");
    Console.WriteLine("14.Mode ");
    Console.WriteLine("15.Sort Two List ");
    Console.WriteLine("16.Merge Two List ");
    Console.WriteLine("Press 0 to Exit ");

    In = Console.ReadLine();
    switch (In)
    {
        case "1":
            Console.WriteLine("Enter Data...After inputing Press F/f to Finish : ");
            while (true)
            {
                Input = Console.ReadLine();
                if (Input == "f" || Input == "F")
                {
                    break;
                }
                bool Convertable = int.TryParse(Input, out int Input1);
                if (Convertable == true)
                {
                    Data.Add(Input1);
                }
                else
                {
                    Console.WriteLine("Wrong Input...Try again or F/f to Finish");
                }
            }
            break;

        case "2":
            if (Data.Count != 0)
            {
                Console.Write("List Data : ");
                PrintData(Data);
            }
            else
            {
                Console.WriteLine("List is Empty");
            }
            break;

        case "3":
            if (Data.Count != 0)
            {
                Console.WriteLine("Press A for Ascending and D for Descending Order : ");
                Input = Console.ReadLine();
                char ch = char.Parse(Input);
                SortData(Data, ch);
                PrintData(Data);
            }
            else
            {
                Console.WriteLine("List is Empty");
            }
            break;

        case "4":
            if (Data.Count != 0)
            {
                Console.WriteLine("Enter the Number you want to Search : ");
                Input = Console.ReadLine();
                bool Convertable = int.TryParse(Input, out int Input1);
                if (Convertable == true)
                {
                    bool ReturningValue = IsItemFound(Data, Input1);
                    Console.WriteLine(ReturningValue);
                }
                else
                {
                    Console.WriteLine("Wrong Input...Try again");
                }
            }
            else
            {
                Console.WriteLine("List is Empty");
            }
            break;

        case "5":
            if (Data.Count != 0)
            {
                Console.WriteLine("Enter the Number you want to Search : ");
                Input = Console.ReadLine();
                bool Convertable = int.TryParse(Input, out int Input1);
                if (Convertable == true)
                {
                    Console.WriteLine($"Index : {Search(Data, Input1)}");
                }
                else
                {
                    Console.WriteLine("Wrong Input...Try again");
                }
            }
            else
            {
                Console.WriteLine("List is Empty");
            }

            break;

        case "6":
            if (Data.Count != 0)
            {
                ReverseData(Data);
                PrintData(Data);
            }
            else
            {
                Console.WriteLine("List is Empty");
            }
            break;
        case "7":
            if (Data.Count != 0)
            {
                Console.WriteLine($"MaxValue : {FindMax(Data)}");

            }
            else
            {
                Console.WriteLine("List is Empty");
            }
            break;
        case "8":
            if (Data.Count != 0)
            {
                Console.WriteLine($"MinValue : {FindMin(Data)}");

            }
            else
            {
                Console.WriteLine("List is Empty");
            }
            break;

        case "9":

            if (Data.Count != 0)
            {
                Console.WriteLine($"Average : {ComputeAverage(Data)}");
            }
            else
            {
                Console.WriteLine("List is Empty");
            }
            break;
        case "10":

            if (Data.Count != 0)
            {
                Console.WriteLine("Enter the Number you want to see the Occurance : ");
                Input = Console.ReadLine();
                bool Convertable = int.TryParse(Input, out int Input1);
                if (Convertable == true)
                {
                    int ReturningValue = CountOccurance(Data, Input1);
                    if (ReturningValue != 0)
                    {
                        Console.WriteLine($"Occurance : {ReturningValue}");
                    }
                    else
                    {
                        Console.WriteLine("Value not Found");
                    }
                }
                else
                {
                    Console.WriteLine("Wrong Input...Try again");
                }


            }
            else
            {
                Console.WriteLine("List is Empty");
            }
            break;
        case "11":
            if (Data.Count != 0)
            {
                Console.WriteLine($"Median : {Data[FindMedian(Data)]}");

            }
            else
            {
                Console.WriteLine("List is Empty");
            }
            break;
        case "12":
            if (Data.Count != 0)
            {
                Console.WriteLine($"Standard Deviation : {ComputeStandardDeviation(Data)}");
            }
            else
            {
                Console.WriteLine("List is Empty");
            }
            break;
        case "13":
            if (Data.Count != 0)
            {
                Console.Write("Uniqe Values : ");
                List<int> result = UniqueValues(Data);
                foreach (int Num in result)
                {
                    Console.Write(Num + " ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("List is Empty");
            }
            break;
        case "14":
            if (Data.Count != 0)
            {
                Console.WriteLine($"Mode : {Mode(Data)}");

            }
            else
            {
                Console.WriteLine("List is Empty");
            }
            break;
        case "15":
            Console.WriteLine("Enter 1st list Data...After inputing Press F/f to Finish : ");
            while (true)
            {
                Input = Console.ReadLine();
                if (Input == "f" || Input == "F")
                {
                    break;
                }
                bool Convertable = int.TryParse(Input, out int Input1);
                if (Convertable == true)
                {
                    Data.Add(Input1);
                    SortData(Data);
                }
                else
                {
                    Console.WriteLine("Wrong Input...Try again or F/f to Finish");
                }
            }
            Console.WriteLine("Enter 2nd list Data...After inputing Press F/f to Finish : ");
            while (true)
            {
                Input = Console.ReadLine();
                if (Input == "f" || Input == "F")
                {
                    break;
                }
                bool Convertable = int.TryParse(Input, out int Input1);
                if (Convertable == true)
                {
                    Data1.Add(Input1);
                    SortData(Data1);
                }
                else
                {
                    Console.WriteLine("Wrong Input...Try again or F/f to Finish");
                }
            }
            Console.WriteLine("TwoSortedList :");
            PrintData(TwoSortList(Data, Data1));
            Data1.Clear();
            Data.Clear();
            break;

        case "16":
            Console.WriteLine("Enter 1st list Data...After inputing Press F/f to Finish : ");
            while (true)
            {
                Input = Console.ReadLine();
                if (Input == "f" || Input == "F")
                {
                    break;
                }
                bool Convertable = int.TryParse(Input, out int Input1);
                if (Convertable == true)
                {
                    Data.Add(Input1);
                }
                else
                {
                    Console.WriteLine("Wrong Input...Try again or F/f to Finish");
                }
            }
            Console.WriteLine("Enter 2nd list Data...After inputing Press F/f to Finish : ");
            while (true)
            {
                Input = Console.ReadLine();
                if (Input == "f" || Input == "F")
                {
                    break;
                }
                bool Convertable = int.TryParse(Input, out int Input1);
                if (Convertable == true)
                {
                    Data1.Add(Input1);
                }
                else
                {
                    Console.WriteLine("Wrong Input...Try again or F/f to Finish");
                }
            }
            Console.WriteLine("Press A for Ascending and D for Descending Order : ");
            string? A = Console.ReadLine();
            bool isConvertable = char.TryParse(A, out char A1);
            if (isConvertable == true)
            {
                PrintData(MergeSortList(Data, Data1, A1));
            }
            else
            {
                Console.WriteLine("Wrong Input");
            }
            Data1.Clear();
            Data.Clear();
            break;
        case "0":
            return 0;

        default:
            Console.WriteLine("Wrong Input...Try again");
            break;
    }
} while (true);

//Task2
void PrintData(List<int> data)
{
    foreach (int i in data)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
}

//Task3
void SortData(List<int> data,char sort='D')
{
    for(int i=0; i< data.Count-1; i++)
    {
        for (int j = 0; j < data.Count-i-1; j++)
        {
            if (sort == 'A'|| sort=='a')
            {

                if (data[j] >= data[j + 1])
                {

                    int temp = data[j];
                    data[j] = data[j + 1];
                    data[j + 1] = temp;
                }
            }
            else if(sort =='D'||sort=='d')
            {
                if (data[j] <= data[j + 1])
                {

                    int temp = data[j];
                    data[j] = data[j + 1];
                    data[j + 1] = temp;
                }
            }

        }
    }

}

//Task4
bool IsItemFound(List<int> data, int Value)
{
    for (int i = 0; i < data.Count-1; i++)
    {
        if(Value == data[i])
        {
            return true;
        }
    }
    return false;
}

//Task5
int Search(List<int> data, int Value)
{
    bool ReturningValue = IsItemFound(data, Value);
    if(ReturningValue==true)
    {
        for(int i = 0;i < data.Count-1;i++)
        {
            if (Value == data[i])
            {
                return i;
            }
        }
    }
    return 0;
}

//Task6
void ReverseData(List<int> data)
{
    for (int i = 0, j = data.Count-1; i < j; i++, j--) 
    {
        int temp = data[i];
        data[i] = data[j];
        data[j] = temp;
    }
}

//Task7
int FindMax(List<int> data)
{
    for(int i = 0; i < data.Count - 1; i++)
    {
        if (data[0] < data[i])
        {
            int temp = data[i];
            data[0] = temp;
        }

    }
    return data[0];
}

//Task8
int FindMin(List<int> data)
{
    for (int i = 0; i < data.Count; i++)
    {
        if (data[0] > data[i])
        {
            int temp = data[i];
            data[0] = temp;
        }

    }
    return data[0];
}

//Task9
float ComputeAverage(List<int> data)
{
    float Sum = 0;
    foreach(int i in data)
    {
        Sum += i;
    }
    return Sum/data.Count;
}

//Task10
int CountOccurance(List<int> data, int Value)
{
    int count = 0;
    foreach(int i in data)
    {
        if(Value==i)
        {
            count++;
        }
    }
    return count;
}

//Task11
int FindMedian(List<int> data)
{
    // For Even Values
    if (data.Count / 2 == 0)
    {
        int Middle1 = data.Count / 2 - 1;
        int Middle2 = data.Count / 2;
        Middle1 += Middle2;
        return Middle1 /= 2;

    }
    // For Odd Values
    else
    {
        int Middle = data.Count / 2;
        return Middle;
    }
}

//Task12
double ComputeStandardDeviation(List<int> data)
{
    double mean = 0;
    foreach(double i in data)
    {
        mean += i;
    }
    mean /= data.Count;

    double Variance = 0;
    foreach (double i in data)
    {
        double diff = i - mean;
        Variance += diff * diff;

        //Variance += Math.Pow(i - mean, 2);
    }
    Variance /= data.Count;

    return Math.Sqrt(Variance);
}

//Task13
List<int> UniqueValues(List<int> data)
{
    return data.Distinct().ToList();
}

//Task14
int Mode(List<int> data)
{
    int Count = 0;
    List<int> data1=UniqueValues(data);
    List<int> data2= new List<int>();
    for(int i = 0; i < data1.Count; i++)
    {
        Count = 0;
        foreach (int value in data)
        {
            if (data1[i] == value)
            {
                Count++;
            }
        }
        data2.Add(Count);
        
    }
    return data1[data2.IndexOf(data2.Max())];
}

//Task15
List<int> TwoSortList(List<int> data,List<int> data1)
{
    data.AddRange(data1);
    SortData(data);
    return data;
}

//Task16
List<int> MergeSortList(List<int> data1, List<int> data2, char A)
{
    data1.AddRange(data2);
    SortData(data1, A);
    return data1;
}