
#region Method1
//Console.WriteLine("Fiboanacci seriyasina baxaq:");
//a:
//int numFirst = 0;
//int numSecond = 1;
//string strNumEnd = Console.ReadLine();
//bool CheckNumEnd = int.TryParse(strNumEnd, out int a);
//if (!CheckNumEnd)
//{
//    Console.WriteLine("Duzgun eded daxil edin..");
//    goto a;
//}

//for (int i = 0; i < a; i++)
//{                                       //0,1,1,2,3,5,8,13
//    Console.WriteLine(numFirst);
//    int sum = numFirst;
//    numFirst = numSecond;
//    numSecond = sum + numSecond;
//}
#endregion


#region Method2
//input:
//Console.Write("Say daxil edin: ");
//bool check = int.TryParse(Console.ReadLine(), out int val);

//if (!check) goto input;

//int[] arr = new int[val];
//arr[0] = 0;
//arr[1] = 1;

//for (int i = 2; i < arr.Length; i++)
//{
//    arr[i] = arr[i - 2] + arr[i - 1];
//}

//foreach (int i in arr)
//{
//    Console.WriteLine(i);
//}
#endregion