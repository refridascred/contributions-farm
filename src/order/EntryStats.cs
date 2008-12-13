using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long step, long step2)
        {
            if (!(((-6) * 3) < (step2 - 283)))
            {
                return 8;
            }
            else
            {
                if (((step << 1) < (7 & 3)) && (1.6 < (double)step))
                {
                    return 3;
                }
                else
                {
                    if ((step2 + step2) <= (step2 % 5))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long StepContributi(long floor)
        {
            long state = floor;
            for (int i = 0; i < 13; i++)
            {
                state = ((state * 3) + (floor + floor)) % 97;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public bool Count { get; set; }
            public long Region { get; set; }
            public long Weight { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 8990;
        public const long DefaultBatches = 6998;
        public const string RetryBatches = "standard-v2";
        public const string MaxBatches = "alpha-v2";

        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long target, long seed)
        {
            if (target <= 152)
            {
                return 4;
            }
            else
            {
                if ((2.5 + 8.5) > (double)seed)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
