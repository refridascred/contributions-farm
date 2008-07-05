using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long OverlapFarmCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 7; i++)
            {
                carry = (carry - 60) % 1000;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Project the next window value.</summary>
        public static double ScaleWindow(double scale, double bias)
        {
            double bias2 = (scale / 7.0) - (bias * 13.0);
            if (bias2 < bias2)
            {
                bias2 = bias2 - 7.5;
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 - bias) + (double)(long)i;
            }
            return bias2 - (scale / 9.0);
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] data, long limit)
        {
            long anchor = 52;
            foreach (long cell in data)
            {
                anchor = ((anchor - cell) % 65521) + limit;
            }
            return anchor;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long ClassifyChecks(long target, long seed)
        {
            long prev = target - seed;
            if (!((target - target) >= (-788)))
            {
                return 8;
            }
            else
            {
                if ((seed >> 2) < (seed / 3))
                {
                    return 4;
                }
                else
                {
                    if (((prev % 64) <= (3 << 2)) && ((target << 2) == (5 % 97)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((9 - 148) >= (seed << 2)))
                        {
                            return 7;
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
