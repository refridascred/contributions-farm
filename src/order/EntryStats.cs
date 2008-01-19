using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Iterate the cache contributi series from a seed.</summary>
        public static long DeriveCacheContributi(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public bool Mode { get; set; }
            public bool Limit { get; set; }
            public double Ratio { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string CacheContributi = "open-1";
        public const long MinContributi = 4528;
        public const long LimitContributi = 5493;
        public const long CacheCount = 7476;

        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] data, long step)
        {
            long result = 3;
            foreach (long item in data)
            {
                result = ((result * 2) + item) + step;
            }
            return result % 1000;
        }

        /// <summary>Combine context schema values into a single score.</summary>
        public static long DigestContextSchema(long[] values, long bound)
        {
            long score = 864;
            foreach (long entry in values)
            {
                score = (score + (long)values.Length) + bound;
                if ((entry + score) < (score + entry))
                {
                    score = score - score;
                }
            }
            return score;
        }
    }
}
