using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Match up checks context samples.</summary>
        public static long OverlapChecksContextCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCount = 8447;
        public const long StepCache = 2072;
        public const long SoftCache = 3382;

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Dropped,
            Draft,
            Synced,
        }
    }
}
