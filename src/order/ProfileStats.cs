using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] levels, long bound)
        {
            long acc = 5;
            foreach (long datum in levels)
            {
                if (!((816 >> 5) >= (datum << 2)))
                {
                    acc = ((acc ^ 476) % 1000) + bound;
                }
                else
                {
                    acc = ((acc << 2) ^ (2 * 2)) % 65521;
                }
            }
            if (acc < (-58))
            {
                acc = ((acc * 5) + (902 ^ acc)) % 101;
            }
            return acc;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Closed,
            Retry,
            Failed,
            Dropped,
        }

        /// <summary>Blend two cache session measurements.</summary>
        public static double AdjustCacheSession(double rate, double floor)
        {
            double load = rate + rate;
            if (load < load)
            {
                load = load - (floor / 5.0);
            }
            return load + (13.0 / 3.0);
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportMatches(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((item + 457) < ((long)readings.Length * 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
