namespace Task3
{
    internal class Program
    {                           
                  
           static void Main(string[] args)
            {
                #region task1
                //Console.Write("massivin elemeentleri sayi=");
                //int n = int.Parse(Console.ReadLine());
                //int[] a = new int[n];
                //Console.Write("c=");
                //int c = int.Parse(Console.ReadLine());
                //for (int i = 0; i < a.Length; i++)
                //{
                //	Console.Write($"a[{i}]=");
                //	a[i] = int.Parse(Console.ReadLine());
                //}
                //for (int i = 0; i < a.Length; i++)
                //{
                //	if (a[i] < c)
                //	{
                //		Console.WriteLine(a[i]);
                //	}
                //}
                #endregion
                #region task2
                //Console.Write("massivin elemeentleri sayi=");
                //int n = int.Parse(Console.ReadLine());
                //int[] a = new int[n];
                //Console.Write("c=");
                //int c = int.Parse(Console.ReadLine());
                //int sum = 0, count=0;
                //for (int i = 0; i < a.Length; i++)
                //{
                //	Console.Write($"a[{i}]=");
                //	a[i] = int.Parse(Console.ReadLine());
                //}
                //for (int i = 0; i < a.Length; i++)
                //{
                //	if (a[i] < c)
                //	{
                //		Console.WriteLine(a[i]);
                //		sum += a[i];
                //		count++;
                //	}
                //}
                //Console.WriteLine($"{c}-den kicik olanlarin ededi ortasi={sum / count}");
                #endregion
                #region task3
                //Console.Write("massivin elemeentleri sayi=");
                //int n = int.Parse(Console.ReadLine());
                //int[] a = new int[n];
                //Console.Write("c=");
                //int c = int.Parse(Console.ReadLine());
                //int total = 1, count = 0;
                //for (int i = 0; i < a.Length; i++)
                //{
                //	Console.Write($"a[{i}]=");
                //	a[i] = int.Parse(Console.ReadLine());
                //}
                //for (int i = 0; i < a.Length; i++)
                //{
                //	if (a[i] < c)
                //	{
                //		Console.WriteLine(a[i]);
                //		total*= a[i];
                //		count++;
                //	}
                //}

                //Console.WriteLine($"{c}-den kicik olanlarin hendesi ortasi={Math.Pow(total,(double)1/count) }");
                #endregion
                #region task4
                //Console.Write("massivin elemeentleri sayi=");
                //int n = int.Parse(Console.ReadLine());
                //int[] a = new int[n];
                //int[] b = new int[n];
                //Console.Write("c=");
                //int c = int.Parse(Console.ReadLine());

                //for (int i = 0; i < a.Length; i++)
                //{
                //	Console.Write($"a[{i}]=");
                //	a[i] = int.Parse(Console.ReadLine());
                //}
                //for (int i = 0; i < a.Length; i++)
                //{
                //	if (a[i] > c)
                //	{
                //		b[i] = a[i];
                //		Console.Write($"{b[i]}  ");

                //	}
                //}
                //int temp = 0;
                //for (int i = 0; i < b.Length - 1; i++)
                //{
                //	for (int j = i; j < b.Length; j++)
                //	{
                //		if (b[i] < b[j])
                //		{
                //			temp = b[i];
                //			b[i] = b[j];
                //			b[j] = temp;
                //		}
                //	}
                //}
                //Console.WriteLine();
                //foreach (var item in b)
                //{
                //	Console.Write($"{item} ");
                //}




                #endregion
                #region task5
                //Console.Write("massivin elemeentleri sayi=");
                //int n = int.Parse(Console.ReadLine());
                //int[] a = new int[n];
                //int[] b = new int[n];
                //Console.Write("c=");
                //int c = int.Parse(Console.ReadLine());
                //int max = b[0];
                //for (int i = 0; i < a.Length; i++)
                //{
                //	Console.Write($"a[{i}]=");
                //	a[i] = int.Parse(Console.ReadLine());
                //}
                //for (int i = 0; i < a.Length; i++)
                //{
                //	if (a[i] < c)
                //	{
                //		b[i] = a[i];
                //		Console.Write($"{b[i]}  ");

                //	}
                //}
                //for (int i = 0; i < a.Length; i++)
                //{
                //	if (b[i] > max)
                //	{
                //		max = b[i];

                //	}
                //}
                //Console.WriteLine($"\nmax={max}");






                #endregion
                #region task6
                Console.Write("massivin elemeentleri sayi=");
                int n = int.Parse(Console.ReadLine());
                int[] y = new int[n];
                int[] x = new int[n];




                for (int i = 0; i < y.Length; i++)
                {
                    Console.Write($"a[{i}]=");
                    y[i] = int.Parse(Console.ReadLine());
                }
                for (int i = 0; i < y.Length; i++)
                {
                    x[i] = y[i] * y[i];
                    Console.Write($"{x[i]}  ");
                }
                #endregion
                #region task7
                //Console.Write("massivin elemeentleri sayi=");
                //int n = int.Parse(Console.ReadLine());
                //int[] a = new int[n];

                //int sum = 0, total = 1;

                //for (int i = 0; i < a.Length; i++)
                //{
                //	Console.Write($"a[{i}]=");
                //	a[i] = int.Parse(Console.ReadLine());
                //}
                //int temp = 0;
                //for(int i = 0; i < a.Length-1; i++)
                //{
                //	for (int j = i; j < a.Length; j++)
                //	{
                //		if (a[i] > a[j])
                //		{
                //			temp = a[i];
                //			a[i] = a[j];
                //			a[j] = temp;

                //		}


                //	}
                //}

                //Console.WriteLine($"min={a[0]},max={a[a.Length - 1]}");
                //sum = a[0] + a[a.Length - 1];
                //total = a[0] * a[a.Length - 1];


                //Console.WriteLine($"ededi orta={(double)sum / 2}\nhendesi orta={Math.Sqrt((double)total)}");
                #endregion
                #region task8

                //int[] y = { 3, 6, 4, 12, 3, 4, 5, 2, 8, 5, 4, 3, 8, 9 };
                //int[] x = { 5, 7, 8, 8, 3, 10, 32, 1, 3, 6, 4, 2, 7, 8 };
                //int[] z = new int[14];


                //for (int i = 0; i < 14; i++)
                //{
                //	z[i] = x[i] * y[i];
                //}
                //foreach(var item in y)
                //{
                //	Console.Write(item + " ");
                //}
                //Console.WriteLine();
                //foreach (var item in x)
                //{
                //	Console.Write(item + " ");
                //}
                //Console.WriteLine();
                //foreach (var item in z)
                //{
                //	Console.Write($"{item} ");
                //}
                #endregion
                #region task9

                //int[] y = { 3, 6, 4, 12, 3, 4, 5, 2, 8, 5, 4, 3, 8, 9, 5, 7, 8, 8, 3, 10, 32, 1, 3, 6, 4 };

                //int[] z = new int[8];
                //double[] x = new double[17];


                //for (int i = 0; i < 8; i++)
                //{
                //	z[i] = y[i] * y[i];
                //}
                //for (int i = 0; i < 17; i++)
                //{
                //	x[i] = (double)y[i + 8] / 4;
                //}
                //Console.WriteLine("ilk 8 ededin kvadrati:");
                //foreach (var item in z)
                //{
                //	Console.Write($"{item} ");
                //}
                //Console.WriteLine($"\nnovbeti 17 ededin 4-e bolunmesinden alinan cavab:");
                //foreach (var item in x)
                //{
                //	Console.Write($"{item}, ");
                //}


                #endregion
                #region task10
                //Console.Write("massivin elemeentleri sayi=");
                //int n = int.Parse(Console.ReadLine());
                //int[] a = new int[n];

                //int count = 0;


                //for (int i = 0; i < a.Length; i++)
                //{
                //	Console.Write($"a[{i}]=");
                //	a[i] = int.Parse(Console.ReadLine());
                //}
                //for (int i = 0; i < a.Length; i++)
                //{
                //	if (a[i] < 0)
                //	{

                //		count++;



                //	}
                //}

                //int[] b = new int[count]; int index = 0;
                //for (int i = 0; i < a.Length; i++)
                //{
                //	if (a[i] < 0)
                //	{

                //		b[index] = a[i];
                //		index++;



                //	}
                //}
                //int temp = 0;
                //for (int i = 0; i < b.Length - 1; i++)
                //{
                //	for (int j = i; j < b.Length; j++)
                //	{
                //		if (b[i] > b[j])
                //		{
                //			temp = b[i];
                //			b[i] = b[j];
                //			b[j] = temp;
                //		}
                //	}
                //}
                //foreach (var item in b)
                //{
                //	Console.Write($"{item} ");
                //}

                //for (int i = b.Length; i < 0; i++)
                //{
                //	if (b[i] < 0)
                //	{
                //		Console.Write(b[i] + " ");
                //	}
                //}
                //Console.WriteLine($"\nmax={b[b.Length - 1]}");






                #endregion
                #region task11
                //Random r = new Random();
                //Console.Write("massivin elemeentleri sayi=");
                //int n = int.Parse(Console.ReadLine());
                //int[] a = new int[n];
                //for(int i = 0; i < a.Length; i++)
                //{
                //	a[i] = r.Next(1, 100);

                //}
                //int temp = 0;
                //for (int i = 0; i < a.Length - 1; i++)
                //{
                //	for (int j = i; j < a.Length; j++)
                //	{
                //		if (a[i] <a[j])
                //		{
                //			temp = a[i];
                //			a[i] = a[j];
                //			a[j] = temp;
                //		}
                //	}
                //}
                //foreach(var item in a)
                //{
                //	Console.Write(item + " ");
                //}
                #endregion
                #region task12
                //int[] y = { 3, 6, 4, 12, 3, 4, 5, 2, 8, 5, 4, 3, 8, 9, 5, 7, 8, 8, 3, 10 };


                //int sum = 0, total = 1;


                //for (int i = 0; i < 10; i++)
                //{
                //	sum += y[i];
                //}
                //for (int i = 10; i < 20; i++)
                //{
                //	total *= y[i];
                //}
                //Console.WriteLine($"ilk 10 ededin ededi ortasi={(double)sum / 10}");
                //Console.WriteLine($"son 10 ededin hendesi ortasi={Math.Pow(total, (double)1 / 10)}");
                #endregion

            }
        }
}