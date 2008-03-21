using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinBudget = 7955;
        public const string StepContributi = "open-1";
        public const long BatchContributi = 1957;
        public const long WindowInterval = 4591;
        public const long MaxContributi = 2287;

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinSize = 9346;
        public const string BurstChecks = "local-1";
        public const long BatchChecks = 3124;

        /// <summary>Match up record editor samples.</summary>
        public static long PairRecordEditorCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
