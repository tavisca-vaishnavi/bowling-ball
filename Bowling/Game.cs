using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling
{
    public class Game
    {
        public int Final = 0; int i = 0;
        public int[] arr_pins = new int[22];
        int b1 = 0, b2 = 0;
        int origin = 0;
        //int flag1 = 0;//even & odd
        //int flag2 = 0;//no of pin=10
        //int flag3 = 0;//sum from both rolls=10
        public void Roll(int pins)
        {
            if (pins == 10 && i % 2 == 0 && i <= 19)
            {
                arr_pins[i] = pins;
                i++;
                arr_pins[i] = 0;
                i++;
            }
            else if (pins == 10 && i % 2 != 0 && i > 19)
            {
                arr_pins[i] = pins;

            }
            else if (pins == 10 && i % 2 == 0 && i > 19)
            {
                arr_pins[i] = pins;
                i++;
            }
            else
            {
                arr_pins[i] = pins;
                i++;
            }





        }
        public int GetScore()
        {
            b1 = arr_pins[20];
            b2 = arr_pins[21];


            origin = arr_pins[0];
            for (int i = 0; i < 20; i++)
            {
                Final += arr_pins[i];
            }
            for (int i = 0; i < 18; i = i + 2)
            {
                if ((arr_pins[i] + arr_pins[i + 1] == 10) && arr_pins[i] != 10)
                {
                    Final += arr_pins[i + 2];
                }
            }
            if ((arr_pins[18] + arr_pins[19] == 10) && arr_pins[18] != 10)
            {
                Final += b1;
            }
            for (int i = 0; i < 16; i++)
            {
                if (i % 2 == 0 && arr_pins[i] == 10)
                {
                    if (arr_pins[i + 2] == 10)
                        Final += arr_pins[i + 2] + arr_pins[i + 4];
                    else
                        Final += arr_pins[i + 3] + arr_pins[i + 2];

                }
            }
            if (arr_pins[16] == 10)
            {
                if (arr_pins[18] == 10)
                    Final += arr_pins[18] + b1;
                else
                    Final += arr_pins[18] + arr_pins[19];
            }
            if (arr_pins[18] == 10)
            {
                Final += b1 + b2;
            }
            return Final;
            // throw new NotImplementedException();
        }

    }
}
