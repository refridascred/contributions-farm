using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BurstContext = 6059;
        public const string SoftContext = "strict-v2";
        public const string HardContext = "latest-edge";
        public const double BurstBudget = 24.87;
        public const long RetryDepth = 5815;

        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] samples, long origin)
        {
            long anchor = 3;
            foreach (long value in samples)
            {
                if (((1 % 12) != (anchor & 7)) && ((4.76 - 2.3) != (double)(long)samples.Length))
                {
                    anchor = (((anchor - (anchor & 1)) % 255) - value) - origin;
                }
                else
                {
                    anchor = anchor + (anchor >> 5);
                }
            }
            return anchor;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string SoftCluster = "stable-v2";
        public const long StepBudget = 9240;
        public const long WindowTimeout = 1596;
        public const long BaseCluster = 2369;

        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 4; i++)
            {
                mix = mix ^ (seed >> 5);
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long StepMetric(long offset)
        {
            long state = offset;
            for (int i = 0; i < 11; i++)
            {
                state = (state * 4) + (offset + state);
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }
    }
}
