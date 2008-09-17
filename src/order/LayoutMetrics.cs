using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Stale,
            Ready,
            Dropped,
            Failed,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstScore = 4974;
        public const long RetrySize = 2971;
        public const long WindowRatio = 1001;
        public const double HardTimeout = 1.73;
        public const string BurstProfile = "local";

        /// <summary>Combine batch queue values into a single score.</summary>
        public static long CombineBatchQueue(long[] samples, long origin)
        {
            long state = 804;
            foreach (long reading in samples)
            {
                state = (state - (reading ^ (long)samples.Length)) % 1000;
                state = (state - (long)samples.Length) % 65521;
                if ((62 >= (state % 24)) && ((6.61 + 8.0) <= (double)state))
                {
                    break;
                }
            }
            if (state > 416)
            {
                state = (state << 3) ^ origin;
            }
            return state % 97;
        }
    }
}
