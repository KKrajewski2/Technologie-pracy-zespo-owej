using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//suma srednia arytmetyczna
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //deklaracja zmiennej dla przechowywania kodu naciśniętego klawisza
            ConsoleKeyInfo WybranaFunkcjonalnosc;
            //wypisanie metryki programu
            Console.WriteLine("\n\n\t\tProgram umożliwia obliczanie sumy, iloczynu średniej arytmetycznej wyrazów ciągu liczbowego");
            // zapisanie instrukcji do_while, która zapewni powtarzanie obliczeń
            do
            {
                //wypisanie menu programu
                Console.WriteLine("\n\tA. Obliczenie sumy wyrazów ciągu liczbowego");
                Console.WriteLine("\n\tB. Obliczenie iloczynu wyrazów ciągu liczbowego");
                Console.WriteLine("\n\tC. Obliczenie sredniej arytmetycznej wyrazów ciągu liczbowego");
                Console.WriteLine("\n\tX. Zakończenie działania");
                //podpowiedź dla użytkownika
                Console.Write("\n\tNaciśnij klawisz odpowiadający wybranej funkcjonalnościści: ");
                //wczytanie kody klawisza, który został wybrany przez użytkownika
                WybranaFunkcjonalnosc = Console.ReadKey();
                //rozpoznanie i obsłużenie wybranej funkcjonalności
                if (WybranaFunkcjonalnosc.Key == ConsoleKey.A)
                {
                    //deklaracje lokalne
                    ushort n;
                    float a; // dla przechowania wartości wczytanego wyrazu ciągu liczbowego 
                    float S; // dla przechowania obliczonej sumy wyrazów ciągu liczbowego
                    //potwierdzenie wybranej funkcjonalności
                    Console.WriteLine("\n\tWYBRANA FUNKCJONALNOŚĆ: A. Obliczenie sumy wyrazów ciągu liczbowego");
                    // wczytanie liczności 'n' i sprawdzenie warunku wejściowego
                    do
                    {
                        //wypisanie zaproszenia do podania wartości 'n'
                        Console.Write("\n\tPodaj liczność ciągu liczbowego n = ");
                        while (!ushort.TryParse(Console.ReadLine(), out n))
                        {
                            Console.WriteLine("\n\tERROR w zapisie podanej liczności ciągu liczbowego wystąpił niedozwolony znak");
                            //ponowne wypisanie zaproszenia do podania wartości 'n'
                            Console.Write("\n\tPodaj ponownie liczność ciągu liczbowego n = ");
                        }
                        // gdy jesteśmy tutaj, to n było podane poprawnie
                        // sparawdzenie warunku wejściowego: n > 0
                        if (n <= 0)
                            //sygnalizacja błędu
                            Console.WriteLine("\n\tERROR: Podana wartość liczności n nie spełnia warunku wejsciowego: n > 0");
                    } while (n <= 0);
                    //kontrone wypisane wczytanej wartości n
                    // Console.WriteLine("\n\tWczytana wartość n= " + n
                    //obliczanie sumy wyrazów ciągu liczbowego
                    S = 0.0F; //ustawienie początkowego stanu obliczeń
                    //obliczenie sumy wyrazów ciągu liczbowego według zależności iteracyjnej
                    for (int i=1; i <= n;i++)
                    {
                        //wczytanie wartości i-tego wyrazu ciągu liczbowego
                        Console.Write("\n\tPodaj wartość {0}-go wyrazu ciągu liczbowego: ", i);
                        while(!float.TryParse(Console.ReadLine(), out a))
                        {
                            //sygnalizacja błędu
                            Console.WriteLine("\n\tERROR w podanym zapisie wyrazu ciągu liczbowego wystąpił niedozwolony znak");
                            //ponowne wczytanie wartości i-tego wyrazu ciągu liczbowego
                            Console.Write("\n\tPodaj ponownie wartość {0}-go wyrazu ciągu liczbowego: ", i);
                        }
                        //obliczenie sumy wyrazów ciągu liczbowego według wzoru iteracyjnego
                        S = S + a;
                    }
                    //Wypisanie wyniku obliczeń
                    Console.WriteLine("\n\tWyniki obliczeń: suma {0} wyrazów szeregu ciągu liczbowego jest równa {1, 6:F2}", n, S);
                }
                else if (WybranaFunkcjonalnosc.Key == ConsoleKey.B)
                {

                    ushort n;
                    float a; 
                    double I;
                    Console.WriteLine("\n\tWYBRANA FUNKCJONALNOŚĆ: B. Obliczenie iloczynu wyrazów ciągu liczbowego");
                    // wczytanie liczności 'n' i sprawdzenie warunku wejściowego
                    do
                    {
                        //wypisanie zaproszenia do podania wartości 'n'
                        Console.Write("\n\tPodaj liczność ciągu liczbowego n = ");
                        while (!ushort.TryParse(Console.ReadLine(), out n))
                        {
                            Console.WriteLine("\n\tERROR w zapisie podanej liczności ciągu liczbowego wystąpił niedozwolony znak");
                            //ponowne wypisanie zaproszenia do podania wartości 'n'
                            Console.Write("\n\tPodaj ponownie liczność ciągu liczbowego n = ");
                        }
                        // gdy jesteśmy tutaj, to n było podane poprawnie
                        // sparawdzenie warunku wejściowego: n > 0
                        if (n <= 0)
                            //sygnalizacja błędu
                            Console.WriteLine("\n\tERROR: Podana wartość liczności n nie spełnia warunku wejsciowego: n > 0");
                    } while (n <= 0);
                    //kontrone wypisane wczytanej wartości n
                    // Console.WriteLine("\n\tWczytana wartość n= " + n
                    //obliczanie sumy wyrazów ciągu liczbowego
                    I = 0.0F; //ustawienie początkowego stanu obliczeń
                    //obliczenie sumy wyrazów ciągu liczbowego według zależności iteracyjnej
                    for (int i = 1; i <= n; i++)
                    {
                        //wczytanie wartości i-tego wyrazu ciągu liczbowego
                        Console.Write("\n\tPodaj wartość {0}-go wyrazu ciągu liczbowego: ", i);
                        while (!float.TryParse(Console.ReadLine(), out a))
                        {
                            //sygnalizacja błędu
                            Console.WriteLine("\n\tERROR w podanym zapisie wyrazu ciągu liczbowego wystąpił niedozwolony znak");
                            //ponowne wczytanie wartości i-tego wyrazu ciągu liczbowego
                            Console.Write("\n\tPodaj ponownie wartość {0}-go wyrazu ciągu liczbowego: ", i);
                        }
                        //obliczenie sumy wyrazów ciągu liczbowego według wzoru iteracyjnego
                        I = I * a;
                    }
                    //Wypisanie wyniku obliczeń
                    Console.WriteLine("\n\tWyniki obliczeń: iloczyn {0} wyrazów szeregu ciągu liczbowego jest równa {1, 8:F2}", n, I);
                }
                else if (WybranaFunkcjonalnosc.Key == ConsoleKey.C)
                {
                    ushort n;
                    float a;
                    float S;
                    float SredniaArytmetyczna;


                    Console.WriteLine("\n\tWYBRANA FUNKCJONALNOŚĆ: C. Obliczenie sredniej arytmetycznej wyrazów ciągu liczbowego");
                    // wczytanie liczności 'n' i sprawdzenie warunku wejściowego
                    do
                    {
                        //wypisanie zaproszenia do podania wartości 'n'
                        Console.Write("\n\tPodaj liczność ciągu liczbowego n = ");
                        while (!ushort.TryParse(Console.ReadLine(), out n))
                        {
                            Console.WriteLine("\n\tERROR w zapisie podanej liczności ciągu liczbowego wystąpił niedozwolony znak");
                            //ponowne wypisanie zaproszenia do podania wartości 'n'
                            Console.Write("\n\tPodaj ponownie liczność ciągu liczbowego n = ");
                        }
                        // gdy jesteśmy tutaj, to n było podane poprawnie
                        // sparawdzenie warunku wejściowego: n > 0
                        if (n <= 0)
                            //sygnalizacja błędu
                            Console.WriteLine("\n\tERROR: Podana wartość liczności n nie spełnia warunku wejsciowego: n > 0");
                    } while (n <= 0);
                    //kontrone wypisane wczytanej wartości n
                    // Console.WriteLine("\n\tWczytana wartość n= " + n
                    //obliczanie sumy wyrazów ciągu liczbowego
                    S = 0.0F; //ustawienie początkowego stanu obliczeń
                    //obliczenie sumy wyrazów ciągu liczbowego według zależności iteracyjnej
                    for (int i = 1; i <= n; i++)
                    {
                        //wczytanie wartości i-tego wyrazu ciągu liczbowego
                        Console.Write("\n\tPodaj wartość {0}-go wyrazu ciągu liczbowego: ", i);
                        while (!float.TryParse(Console.ReadLine(), out a))
                        {
                            //sygnalizacja błędu
                            Console.WriteLine("\n\tERROR w podanym zapisie wyrazu ciągu liczbowego wystąpił niedozwolony znak");
                            //ponowne wczytanie wartości i-tego wyrazu ciągu liczbowego
                            Console.Write("\n\tPodaj ponownie wartość {0}-go wyrazu ciągu liczbowego: ", i);
                        }
                        //obliczenie sumy wyrazów ciągu liczbowego według wzoru iteracyjnego
                        S = S + a;
                        
                    }
                    SredniaArytmetyczna = S / n;
                    //Wypisanie wyniku obliczeń
                    Console.WriteLine("\n\tWyniki obliczeń: Sredni arytmetycznej {0} wyrazów szeregu ciągu liczbowego jest równa {1, 6:G}", n, SredniaArytmetyczna);
                    Console.ReadKey();
                }
                else if (WybranaFunkcjonalnosc.Key != ConsoleKey.X)
                {
                    Console.WriteLine("\n\tERROR: nacisnąłęś 'nieodpowiedni' klawisz");
                    Console.ReadKey();
                }
            } while (WybranaFunkcjonalnosc.Key != ConsoleKey.X);
        }
    }
}
