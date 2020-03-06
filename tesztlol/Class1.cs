using System;

namespace tesztlol
{
    public class Eloadas
    {
        private bool[,] bk;

        public Eloadas(int numOfRows, int numOfPlaces)
        {
            if (numOfRows <= 0 || numOfPlaces <= 0)
            {
                throw new ArgumentException();
            }
            this.bk = new bool[numOfRows, numOfPlaces];
            for (int i = 0; i < bk.GetLength(0); i++)
            {
                for (int j = 0; j < bk.GetLength(1); j++)
                {
                    bk[i, j] = false;
                }
            }
        }
        public bool book()
        {
            for (int i = 0; i < bk.GetLength(0); i++)
            {
                for (int j = 0; j < bk.GetLength(1); j++)
                {
                    if (bk[i, j] == false)
                    {
                        bk[i, j] = true;
                        return true;
                    }
                }
            }
            return false;
        }
        public int freeSpace()
        {
            int freeSpaceIndex = 0;
            for (int i = 0; i < bk.GetLength(0); i++)
            {
                for (int j = 0; j < bk.GetLength(1); j++)
                {
                    if (bk[i, j] == false)
                    {
                        freeSpaceIndex++;
                    }
                }
            }
            return freeSpaceIndex;
        }
        public bool Full()
        {
            if (freeSpace() <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Booked(int numOfRow, int numOfPlace)
        {
            if (numOfRow > bk.GetLength(0) || numOfPlace > bk.GetLength(1))
            {
                throw new ArgumentException();
            }
            else
            {
                if (bk[numOfRow, numOfPlace] == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
