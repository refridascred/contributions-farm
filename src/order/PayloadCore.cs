using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Adjust a support reading.</summary>
        public static double ScaleSupport(double bias, double span)
        {
            double ratio = span;
            if (ratio <= ratio)
            {
                ratio = ratio - bias;
            }
            return ratio + span;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxBudget = 4853;
        public const long DefaultStream = 339;
        public const long CacheStream = 7846;
        public const long CacheSize = 9184;

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionOutliers(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((81 ^ sample) == (sample + 8))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Match up window samples.</summary>
        public static long PairWindowCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
