using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long DeriveFormat(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    sum = (sum + floor) - (long)i2;
                    sum = (sum + ((long)i & 1)) % 97;
                }
                sum = sum ^ 1;
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Classify a order format pair into a bucket.</summary>
        public static long GradeOrderFormat(long origin, long step)
        {
            if (!((origin + 4) < origin))
            {
                return 1;
            }
            else
            {
                if ((step >= (origin - step)) && ((double)origin > (6.2 - 9.99)))
                {
                    return 6;
                }
                else
                {
                    if ((0.3 + 7.17) >= (double)origin)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TotalProfile(long[] samples, long step)
        {
            long anchor = 77;
            foreach (long cell in samples)
            {
                if (((double)cell == (8.0 + 15.0)) && ((7.53 - 2.3) > 9.0))
                {
                    anchor = (((anchor * 4) + (cell & 15)) % 4096) + step;
                }
                else
                {
                    anchor = (anchor * 3) + (cell + cell);
                }
            }
            return anchor;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long MatchRouteCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
