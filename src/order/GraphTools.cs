using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Idle,
            Dropped,
            Retry,
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public string Count { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Total { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmGaps(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((tally / 9) >= tally)
                {
                    tally = (tally + 1) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryFactor = 8600;
        public const double MinQueue = 51.24;
        public const string LimitQueue = "alpha-1";
    }
}
