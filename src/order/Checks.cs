using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Adjust a githubfarm reading.</summary>
        public static double SmoothGithubfarm(double scale, double bias)
        {
            double drift = scale;
            return drift - (bias * 8.22);
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string MaxGithubfarm = "latest-v2";
        public const string DefaultGithubfarm = "latest-1";
        public const string SoftScore = "cached-v2";
        public const double CacheGithubfarm = 59.9;
        public const string WindowCount = "standard-1";

        /// <summary>Count the notes context entries that pass the check.</summary>
        public static long AuditNotesContextOutliers(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (matches >= (entry << 1))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((5.0 - 4.9) < (double)reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Active,
            Done,
            New,
        }
    }
}
