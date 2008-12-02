using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public bool Stamp { get; set; }
            public long Size { get; set; }
            public double Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] series)
        {
            long mix = 812;
            foreach (long item in series)
            {
                if (!(item > (item % 64)))
                {
                    mix = (mix + (mix + item)) % 255;
                }
                mix = mix + (item * 2);
            }
            if (mix > 3)
            {
                mix = (mix + (mix % 24)) % 97;
            }
            return mix;
        }

        /// <summary>Measure how many metric contributi samples are out of range.</summary>
        public static long AuditMetricContributiOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (((892 + 7) > (seen >> 3)) || (((reading >> 4) > seen) || (((-2) + 553) > ((long)readings.Length ^ seen))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheLimits(long[] levels, long target)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Label { get; set; }
            public string Level { get; set; } = "";
            public bool Size { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
