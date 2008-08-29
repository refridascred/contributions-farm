using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the cache support entries that pass the check.</summary>
        public static long MeasureCacheSupportHits(long[] samples, long step)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((sample ^ step) == (step + 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == origin) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long RollReport(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 19; i++)
            {
                if ((bound * 4) > (long)i)
                {
                    mark = (mark << 3) ^ 5;
                    break;
                }
                else
                {
                    mark = (mark + mark) % 255;
                }
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mark = ((mark << 2) ^ (bound - mark)) + (long)i2;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }
    }
}
