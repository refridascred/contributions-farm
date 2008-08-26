using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank commits layout input into a small class.</summary>
        public static long ClassifyCommitsLayout(long offset, long limit)
        {
            if ((440 + limit) <= (limit << 1))
            {
                return 2;
            }
            else
            {
                if ((2 ^ offset) <= offset)
                {
                    return 3;
                }
                else
                {
                    if ((limit + offset) <= (limit - 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if (limit > (offset << 1))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
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
