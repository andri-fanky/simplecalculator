using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    /// <summary>
    /// Kalkulator class
    /// </summary>
    /// <remarks>class Kalkulator dapat membuat operasi tambah, kurang, kali, bagi</remarks>
    public class Calculator
    {
        public String User(string name)
        {
            return name;
        }

        /// <summary>
        /// operasi penjumlahan
        /// </summary>
        /// <param name="bil1">bilangan pertama dalam operasi penjumlahan</param>
        /// <param name="bil2">bilangan kedua yang akan ditambah dengan bilangan pertama</param>
        /// <returns>hasil dari penjumlahan bilangan pertama dan bilangan kedua</returns>
        public double Penjumlahan(double bil1, double bil2)
        {
            return bil1 + bil2;
        }

        /// <summary>
        /// operasi pengurangan
        /// </summary>
        /// <param name="bil1">bilangan pertama dalam operasi pengurangan</param>
        /// <param name="bil2">bilangan kedua yang akan mengurangi bilangan pertama</param>
        /// <returns>hasil dari pengurangan bilangan pertama dan bilangan kedua</returns>
        public double Pengurangan(double bil1, double bil2)
        {
            return bil1 - bil2;
        }

        /// <summary>
        /// operasi perkalian
        /// </summary>
        /// <param name="bil1">bilangan pertama dalam operasi perkalian</param>
        /// <param name="bil2">bilangan kedua yang akan dikali dengan bilangan pertama</param>
        /// <returns>hasil dari perkalian bilangan pertama dan bilangan kedua</returns>
        public double Perkalian(double bil1, double bil2)
        {
            return bil1 * bil2;
        }

        /// <summary>
        /// operasi pembagian
        /// </summary>
        /// <param name="bil1">bilangan pertama dalam operasi pembagian</param>
        /// <param name="bil2">bilangan kedua yang akan membagi bilangan pertama</param>
        /// <returns>hasil dari pembagian bilangan pertama dan bilangan kedua</returns>
        public double Pembagian(double bil1, double bil2)
        {
            return bil1 / bil2;
        }
    }
}
