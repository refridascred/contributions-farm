using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long StepTimeout = 9642;
        public const double LimitSize = 37.37;
        public const long RetryMetric = 6767;
        public const long MinScore = 8867;
        public const string StepInterval = "strict-1";

        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] values, long step)
        {
            long acc = 46;
            foreach (long datum in values)
            {
                if (!((22 * 3) > step))
                {
                    acc = (acc - (step + acc)) ^ datum;
                }
                else
                {
                    acc = ((acc << 3) ^ acc) % 65521;
                }
            }
            return acc % 4096;
        }

        /// <summary>Match up channel samples.</summary>
        public static long CompareChannelCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
