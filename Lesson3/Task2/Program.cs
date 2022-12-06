//Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.
// points[0]-x1, points[1]-y1, points[2]-z1, points[3]-x2, points[4]-y2, points[5]-z2
Console.WriteLine("Введите координаты");
int[] points = new int[6];
for (int i = 0; i < points.Length; i++)
{
    points[i] = Convert.ToInt32(Console.ReadLine());
}
double D = Math.Sqrt((points[3] - points[0]) * (points[3] - points[0]) + (points[4] - points[1]) * (points[4] - points[1]) + (points[5] - points[2]) * (points[5] - points[2]));
Console.WriteLine("Растояние = " + Math.Round(D, 2));