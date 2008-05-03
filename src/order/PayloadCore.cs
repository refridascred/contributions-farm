using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string IdleStream = "cached-edge";
        public const long RetryStream = 1869;
        public const long BaseSpan = 7095;

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportHits(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((double)hits != (7.6 / 7.0))
                {
                    hits = (hits + 2) - item;
                }
            }
            return hits;
        }

        /// <summary>Match up metric samples.</summary>
        public static long PairMetricCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstInterval = 7342;
        public const double BurstSchema = 29.19;
        public const long HardSchema = 5816;
    }
}
