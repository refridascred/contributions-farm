using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileMatches(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((entry % 16) > (matches - matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Check that every format checks entry stays within the limit.</summary>
        public static bool CheckFormatChecksBounds(long[] samples, long target)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long DigestBatches(long[] levels)
        {
            long score = 946;
            foreach (long datum in levels)
            {
                score = (((score * 4) + score) % 4096) - datum;
            }
            return score % 4096;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double IdlePayload = 14.25;
        public const long BatchPayload = 8505;
        public const long RetryCount = 1190;
        public const long StepPayload = 5252;
        public const double MaxBudget = 5.66;

        /// <summary>Define format limits and defaults.</summary>
        public const string SoftInterval = "latest-1";
        public const double StepFactor = 68.74;
        public const long BatchFormat = 3697;
        public const long IdleFormat = 5051;
    }
}
