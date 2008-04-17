using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Count { get; set; }
            public long Size { get; set; }
            public bool Region { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string RetryGraph = "open";
        public const long SoftInterval = 2785;
        public const long CacheDepth = 7505;

        /// <summary>Find the first entry record entry that matches the target.</summary>
        public static long SeekEntryRecordIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < bound) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long SeriesGithubfarm(long target)
        {
            long total = target;
            for (int i = 0; i < 4; i++)
            {
                if ((target & 7) < (total + target))
                {
                    total = (total ^ (target << 1)) % 1000;
                    total = (total + (48 / 7)) % 65521;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Measure how many record format samples are out of range.</summary>
        public static long TallyRecordFormatMatches(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen + entry) <= seen)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
