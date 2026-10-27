using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int PointsPerEnemy = 150;
            int enemyCount = int.Parse(Console.ReadLine());
            int totalSeconds = int.Parse(Console.ReadLine());
            int diem = enemyCount * PointsPerEnemy;
            int phut = totalSeconds / 60;
            int giay = totalSeconds % 60;
            double dichMoiPhut = enemyCount * 60.0 / totalSeconds;
            Console.WriteLine("Diem: " + diem);
            Console.WriteLine("Thoi gian: " + phut + " phut " + giay + " giay");
            Console.WriteLine("Dich/phut: " + dichMoiPhut);
        }
    }
}
