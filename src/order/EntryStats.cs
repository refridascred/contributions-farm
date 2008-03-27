using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Retry,
            Active,
            Synced,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowScore = 9236;
        public const string SoftBatches = "legacy-edge";
        public const long MaxSpan = 113;
        public const long CacheSpan = 3831;

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long DigestGithubfarm(long[] readings)
        {
            long anchor = 218;
            foreach (long value in readings)
            {
                if ((anchor + anchor) != (value % 7))
                {
                    anchor = (anchor * 5) + (9 * 4);
                }
                if (((15 % 8) != (value * 3)) && ((anchor - 551) < (anchor & 15)))
                {
                    break;
                }
            }
            if (anchor > 659)
            {
                anchor = (anchor ^ anchor) % 4096;
            }
            return anchor % 4096;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long ComparePayloadCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a command metric reading.</summary>
        public static double ScaleCommandMetric(double bias, double span)
        {
            double bias2 = bias;
            if (bias2 >= bias)
            {
                bias2 = (bias2 + (bias2 * 4.02)) - span;
            }
            else
            {
                bias2 = bias2 - (bias + 0.29);
            }
            return bias2 - (double)790;
        }
    }
}
