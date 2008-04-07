using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountRange(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of metrics session readings.</summary>
        public static long CombineMetricsSession(long[] series, long floor)
        {
            long score = -773;
            foreach (long datum in series)
            {
                if ((double)floor > (15.0 * 18.0))
                {
                    score = ((score << 2) ^ datum) % 101;
                }
            }
            return score;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string WindowNotes = "fallback-v2";
        public const long BatchCount = 6079;
        public const long RetryCount = 9304;

        /// <summary>Define route limits and defaults.</summary>
        public const double CacheSize = 20.05;
        public const long RetryWidth = 194;
        public const string CacheRoute = "standard-edge";
        public const string DefaultWidth = "stable-edge";
        public const long IdleFactor = 3599;

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Rank { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
