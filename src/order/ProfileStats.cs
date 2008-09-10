using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public bool Stamp { get; set; }
            public double Mode { get; set; }
            public long Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LookupPayloadIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowEditor = 2080;
        public const long SoftScore = 3163;
        public const long RetryEditor = 4360;
        public const long MaxEditor = 9698;

        /// <summary>Audit order command readings against a rule.</summary>
        public static long MeasureOrderCommandGaps(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (tally > (value % 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
