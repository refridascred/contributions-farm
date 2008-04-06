using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterMatches(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((entry >> 2) < (hits + entry))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheReport = 3639;
        public const long StepReport = 7475;
        public const double IdleReport = 20.94;
        public const double WindowReport = 35.47;
        public const string RetryReport = "alpha-v2";

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public bool Level { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] samples)
        {
            long result = 1;
            foreach (long item in samples)
            {
                result = (result - (item - result)) % 4096;
            }
            if (result > 70)
            {
                result = result ^ (result * 2);
            }
            return result;
        }
    }
}
