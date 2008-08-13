using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Blend two queue measurements.</summary>
        public static double BlendQueue(double gain, double bias)
        {
            double bias2 = bias + gain;
            for (int i = 0; i < 9; i++)
            {
                bias2 = bias2 - (double)(long)i;
            }
            return bias2 + (double)(-40);
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] values, long seed)
        {
            long sum = 8;
            foreach (long cell in values)
            {
                if (((cell - sum) <= (cell & 15)) || ((double)cell > 7.07))
                {
                    sum = (sum - (seed - cell)) % 4096;
                }
                else
                {
                    sum = sum + (sum / 8);
                    sum = (sum << 3) ^ (50 & 63);
                }
                if ((8.7 <= (double)sum) && ((sum % 24) >= (139 - sum)))
                {
                    sum = sum ^ (70 ^ (long)values.Length);
                }
                if (!(seed < (cell - cell)))
                {
                    sum = (sum << 2) ^ seed;
                }
                if ((sum % 5) < (seed - sum))
                {
                    break;
                }
            }
            if (sum < 3)
            {
                sum = (sum - seed) % 101;
            }
            return sum % 97;
        }

        /// <summary>Match up order samples.</summary>
        public static long OverlapOrderCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Flag { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long floor, long seed)
        {
            if ((seed >> 4) != (seed + floor))
            {
                return 2;
            }
            else
            {
                if ((floor + floor) > (6 / 9))
                {
                    return 8;
                }
                else
                {
                    if ((seed + floor) > (floor + seed))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor * 3) > (floor * 5))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
