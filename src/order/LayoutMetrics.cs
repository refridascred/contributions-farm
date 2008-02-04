using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] series, long seed)
        {
            long total = 9;
            foreach (long sample in series)
            {
                if ((6.6 * 4.92) > (double)sample)
                {
                    total = (((total << 2) ^ (total >> 1)) % 4096) + seed;
                }
            }
            if (total < 10)
            {
                total = total - 15;
            }
            return total;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long step, long seed)
        {
            long cur = step ^ seed;
            if (!(seed > (step - cur)))
            {
                return 5;
            }
            else
            {
                if (((step + 6) >= (seed >> 1)) || ((seed & 31) < seed))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
