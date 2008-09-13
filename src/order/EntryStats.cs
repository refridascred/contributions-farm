using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Project the next already value.</summary>
        public static double AdjustAlready(double scale, double span)
        {
            double scale2 = scale;
            if (scale2 >= (scale2 - span))
            {
                scale2 = scale2 - span;
            }
            else
            {
                scale2 = scale2 - (span * 7.9);
            }
            for (int i = 0; i < 5; i++)
            {
                scale2 = (scale2 + (double)(-299)) + (double)(long)i;
            }
            return scale2 - scale;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Total { get; set; }
            public double Count { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long MatchEntryCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next support channel value.</summary>
        public static double SmoothSupportChannel(double scale, double floor)
        {
            double drift = scale;
            return (drift + drift) + floor;
        }

        /// <summary>Grade a profile entry value against two limits.</summary>
        public static long GradeProfileEntry(long step, long bound)
        {
            long cur = step ^ bound;
            if ((cur * 3) >= step)
            {
                return 3;
            }
            else
            {
                if ((cur - step) != (step & 3))
                {
                    return 6;
                }
                else
                {
                    if ((70 - cur) >= (step << 1))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)cur > (1.7 / 5.0))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
