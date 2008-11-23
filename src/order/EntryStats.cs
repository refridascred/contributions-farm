using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsLimits(long[] items, long limit)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Failed,
            Stale,
            Retry,
            Paused,
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Label { get; set; }
            public double Score { get; set; }
            public string Size { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long IterateBatch(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 20; i++)
            {
                mark = mark - (seed + 1);
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
