using System;
using System.IO;

namespace Flujos
{
    class Program
    {
        static void Main(string[] args)
        {
            Stream fs = null;
            int valor = 0;

            try
            {
                using (fs = new FileStream("archivo.txt", FileMode.Open, FileAccess.Read))
                {
                    // Obtenemos el número de bytes
                    long cantidad = fs.Length;
                    Console.WriteLine($"El archivo tiene una longitud de {cantidad} bytes");
                    /*
                    // Leemos byte por byte
                    for (long i = 0; i < cantidad; i++)
                    {
                        // Establecemos la posición
                        fs.Seek(i, SeekOrigin.Begin);
                        valor = fs.ReadByte();
                        Console.WriteLine($"Posición {i}: {(char)valor}");
                    }

                    Console.WriteLine("----------------------------");

                    // Leemos ahora en el otro sentido
                    for (long i = 1; i <= cantidad; i++)
                    {
                        fs.Seek(-i, SeekOrigin.End);
                        valor = fs.ReadByte();
                        Console.WriteLine($"Posición {cantidad - i}: {(char)valor}");
                    }

                    Console.WriteLine("----------------------------");

                    fs.Seek(0, SeekOrigin.Begin);


                    // Leer sin conocer la longitud
                    while((valor = fs.ReadByte()) > 0)
                    {
                        Console.WriteLine($"{(char)valor}");
                    }
                    */
                    StreamReader sr = null;
                    using (sr = new StreamReader(fs))
                    {
                        //string linea = sr.ReadLine();
                        //Console.WriteLine(linea);

                        //linea = sr.ReadLine();
                        //Console.WriteLine(linea);
                        while(!sr.EndOfStream)
                            Console.WriteLine(sr.ReadLine());

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: {ex.Message}");
            }

            using (fs = new FileStream("escribirarchivo.txt", FileMode.Create, FileAccess.Write))
            {
                StreamWriter sw = null;
                using (sw = new StreamWriter(fs))
                {
                    sw.WriteLine("Esto es un archivo escrito desde C#");
                }
            }

            using (Stream ms = new MemoryStream())
            {
                using (fs = new FileStream("escribirarchivo.txt", FileMode.Open, FileAccess.Read))
                {
                    fs.CopyTo(ms);
                }

                ms.Seek(0, SeekOrigin.Begin);

                using (StreamReader sr = new StreamReader(ms))
                {
                    while(!sr.EndOfStream)
                    {
                        Console.WriteLine(sr.ReadLine());
                    }
                }

                using (fs = new FileStream("archivo.txt", FileMode.Append, FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.WriteLine("Tercera Línea");
                        sw.WriteLine("Cuarta Línea");
                        sw.WriteLine("Quinta Línea");
                    }
                }
            }

        }
    }
}
