using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstCommits = 6653;
        public const string SoftScore = "alpha-1";
        public const long LimitCommits = 4032;
        public const long SoftRatio = 5569;

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public string Region { get; set; } = "";
            public long Count { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesGaps(long[] items, long offset)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((((hits + datum) != (offset & 31)) || (datum < 34)) && ((((long)items.Length & 127) >= offset) && (datum <= 3)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double weight, double offset)
        {
            double drift = (offset + weight) + (weight + weight);
            if (drift < (double)(-5))
            {
                drift = drift + drift;
            }
            else
            {
                drift = drift - offset;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (double)(-247)) + (double)(long)i;
            }
            return drift + offset;
        }
    }
}
