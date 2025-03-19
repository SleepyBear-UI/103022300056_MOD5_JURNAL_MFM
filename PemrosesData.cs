using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod5
{
    public class PemrosesData
    {
        // PemrosesDataTerbesar sebuah method yang berisikan parameter 3 data berupa
        // data1 data2 dan data3
        public void PemrosesDataTerbesar<T>(T datas1, T datas2, T datas3)
        {
            dynamic data1 = (dynamic)datas1;
            dynamic data2 = (dynamic)datas2;
            dynamic data3 = (dynamic)datas3;

            int high = data1;

            // Mencari Data berdasarkan data terbesar jika menemukan data terbesar maka akan output data terbesar
            if (data2 < high && data3 < high)
            {
                Console.WriteLine(high + " merupakan nilai terbesar");
            }
            else if (high < data2 && data3 < data2)
            {
                Console.WriteLine(data2 + " merupakan nilai terbesar");
            }
            else {
                Console.WriteLine(data3 + " merupakan nilai terbesar");
            }
        }
    }
}
