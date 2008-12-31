using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public string Region { get; set; } = "";
            public string Flag { get; set; } = "";
            public bool Owner { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Measure how many stream cache samples are out of range.</summary>
        public static long MeasureStreamCacheGaps(long[] readings, long target)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count > 2) && ((target - cell) >= count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterGaps(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (seen >= (datum ^ datum))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long IterateCommits(long step)
        {
            long result = step;
            for (int i = 0; i < 22; i++)
            {
                if (18.0 > (double)result)
                {
                    result = result ^ (long)i;
                }
                result = (result ^ (step * 3)) % 255;
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string MinBudget = "fallback";
        public const double BatchFactor = 77.17;
        public const string CacheContributi = "staging-1";
    }
}
