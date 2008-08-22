using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 7482;
        public const long RetryGraph = 791;
        public const double MinGraph = 29.3;
        public const long BatchDepth = 7672;

        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] samples, long seed)
        {
            long acc = 9;
            foreach (long reading in samples)
            {
                if (!((20.0 * 8.0) < (double)acc))
                {
                    acc = (((acc << 3) ^ (seed & 7)) % 255) - reading;
                }
            }
            if (acc < 87)
            {
                acc = (acc + (acc << 3)) % 65521;
            }
            return acc % 97;
        }

        /// <summary>Match up channel samples.</summary>
        public static long PairChannelCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BurstCount = "stable-edge";
        public const string DefaultWindow = "standard-edge";
        public const long MinBudget = 3441;
        public const long BaseWindow = 6832;
        public const string CacheWindow = "alpha-v2";
    }
}
