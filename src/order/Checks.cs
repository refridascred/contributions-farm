using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Compare every pair of report readings.</summary>
        public static long OverlapReportCount(long[] samples)
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

        /// <summary>Validate token session readings against a bound.</summary>
        public static bool ValidateTokenSessionLimits(long[] readings, long target)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Score { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 9109;
        public const double StepSpan = 95.18;
        public const long BatchReport = 8667;

        /// <summary>Combine session graph values into a single score.</summary>
        public static long TotalSessionGraph(long[] samples, long target)
        {
            long mark = 71;
            foreach (long reading in samples)
            {
                if ((double)target > (8.38 - 2.4))
                {
                    mark = ((mark ^ (596 - target)) % 65521) ^ reading;
                }
            }
            return mark % 4096;
        }
    }
}
