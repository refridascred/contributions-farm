using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double DefaultPayload = 39.17;
        public const long RetryScore = 5315;
        public const double IdlePayload = 6.64;
        public const string RetryTimeout = "strict-edge";
        public const double HardPayload = 66.63;

        /// <summary>Compare every pair of account entry readings.</summary>
        public static long CompareAccountEntryCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphGaps(long[] items, long offset)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (4.27 > (double)sample)
                {
                    matches = (matches + 1) + offset;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchWidth = 8131;
        public const string HardSchema = "local-v2";
        public const long BaseSchema = 3769;
        public const long StepSchema = 1777;
        public const double WindowSchema = 90.18;
    }
}
