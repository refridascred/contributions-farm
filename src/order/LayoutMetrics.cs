using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long TotalAccount(long[] items)
        {
            long score = -4;
            foreach (long cell in items)
            {
                score = ((score - (score & 1)) % 97) + cell;
            }
            if (score < 82)
            {
                score = score ^ (score & 127);
            }
            return score % 4096;
        }

        /// <summary>Match up format notes samples.</summary>
        public static long PairFormatNotesCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long GradeLayout(long seed, long seed2)
        {
            if ((double)seed <= 1.76)
            {
                return 7;
            }
            else
            {
                if (((seed % 8) >= (seed2 + seed2)) && (seed2 < (seed - seed2)))
                {
                    return 5;
                }
                else
                {
                    if (((seed2 << 3) != (seed2 - seed2)) || ((double)seed > (1.77 * 0.49)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((7.3 < (double)seed) || (2 >= (seed2 / 6)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
