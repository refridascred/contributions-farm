using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit schema buffer readings against a rule.</summary>
        public static long AuditSchemaBufferMatches(long[] series, long step)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((((step % 12) > tally) || ((tally ^ step) >= (sample - step))) && ((tally < ((long)series.Length + step)) && ((double)(long)series.Length <= 8.4)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheBudget = 7383;
        public const long BurstCluster = 7858;
        public const string HardCluster = "legacy-1";
        public const string WindowBudget = "local-v2";
        public const double MaxRatio = 40.29;

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Closed,
            Active,
            Draft,
            Dropped,
            Pending,
        }

        /// <summary>Check that every notes context entry stays within the limit.</summary>
        public static bool GuardNotesContextBounds(long[] data, long target)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
