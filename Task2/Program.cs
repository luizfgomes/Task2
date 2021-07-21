using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2 {

    class Program {

        static void Main(string[] args) {

            int[] A = new int[11];
            A[0] = 1;
            A[1] = 3;
            A[2] = 2;
            A[3] = 1;
            A[4] = 2;
            A[5] = 1;
            A[6] = 5;
            A[7] = 3;
            A[8] = 3;
            A[9] = 4;
            A[10] = 2;
            Console.WriteLine(Solution.solution(A));
            Console.ReadLine();

            A = new int[2];
            A[0] = 5;
            A[1] = 8;
            Console.WriteLine(Solution.solution(A));
            Console.ReadLine();

            A = new int[4];
            A[0] = 1;
            A[1] = 1;
            A[2] = 1;
            A[3] = 1;
            Console.WriteLine(Solution.solution(A));
            Console.ReadLine();
        }
    }

    class Solution {

        public static int solution(int[] A) {

            if (CheckValidNumbers.ValidArray(A)) {

                return CalcBrushstrokes.CalcAllWalls(A);
            }

            return -1;
        }
    }

    class CheckValidNumbers {

        public static bool ValidArray(int[] A) {

            bool validation = true;
            foreach (int i in A) {

                if (i >= 1 && i <= 1000000000 && validation) ;
                else validation = false;

            }
            return validation;
        }
    }


    class StaticsValues {

        public static int x { get; set; }
        public static int y { get;  set; }

        public static void SetY(int _y) {

            y = _y;
        }

        public static int GetY() {

            return y;
        }

        public static void SetX(int _x) {

            x = _x;
        }


        public static int GetX() {

            return x;
        }
    }

    class CalcBrushstrokes {

        public static int CalcAllWalls(int[] A) {

            int mostValue = 0;

            for (int i = 0; i < A.Length; i++) {

                if (mostValue < A[i]) mostValue = A[i];
            }

            StaticsValues.SetY(mostValue);
            StaticsValues.SetX(A.Length);
            return CalcPaintWalls(A);
        }

        public static int CalcPaintWalls(int[]A) {
            
            int x = StaticsValues.GetX();
            int y = StaticsValues.GetY();

            bool pulse = false;
            int countPaintBrushstrokes = 1;

            for (int i = 1; i < y; i++) {

                if(pulse == true && A[0] >= i) {

                    countPaintBrushstrokes++;
                }

                for (int j = 0; j <x; j++) {

                    if (A[j] >= i) {

                        if (!pulse) countPaintBrushstrokes++;
                        pulse = true;
                    }
                    else {

                        pulse = false;
                    }
                }
            }

            return countPaintBrushstrokes;
        }
    }
}
