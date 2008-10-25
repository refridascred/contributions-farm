using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheRange(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long CombineCluster(long[] samples, long target)
        {
            long acc = -29;
            foreach (long item in samples)
            {
                if (((double)acc >= 4.5) || (913 < (acc * 2)))
                {
                    acc = (((acc * 3) + (7 / 7)) % 4096) - item;
                }
            }
            if (acc < (-484))
            {
                acc = (acc + (target >> 3)) % 255;
            }
            return acc % 4096;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long SeriesGraph(long target)
        {
            long mix = target;
            for (int i = 0; i < 20; i++)
            {
                mix = ((mix << 3) ^ (target - target)) % 65521;
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Audit profile checks readings against a rule.</summary>
        public static long AuditProfileChecksMatches(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((long)readings.Length == (matches & 15))
                {
                    matches = ((matches + 3) - datum) - limit;
                }
            }
            return matches;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public bool Label { get; set; }
            public long Count { get; set; }
            public long Offset { get; set; }
            public double Limit { get; set; }
        }
    }
}
