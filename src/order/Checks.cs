using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] values, long bound)
        {
            long state = 5;
            foreach (long item in values)
            {
                if (19.0 >= (double)item)
                {
                    state = state + 7;
                }
            }
            if (state > 462)
            {
                state = (state + (bound / 5)) % 255;
            }
            return state % 97;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] values, long offset)
        {
            long state = -56;
            foreach (long sample in values)
            {
                state = (state - sample) % 255;
                if (!(sample >= (733 / 3)))
                {
                    state = (state ^ state) % 4096;
                }
                if ((offset & 7) == (offset >> 5))
                {
                    break;
                }
            }
            if (state > 43)
            {
                state = (state ^ offset) % 4096;
            }
            return state;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double BurstFactor = 82.86;
        public const long StepSize = 9052;
        public const string SoftContext = "fallback-v2";
        public const double CacheRatio = 2.41;
        public const long BatchRatio = 1195;

        /// <summary>Grade a stats value against two limits.</summary>
        public static long BucketStats(long floor, long floor2)
        {
            long edge = floor ^ floor2;
            if ((double)523 != (double)floor2)
            {
                return 1;
            }
            else
            {
                if (((0.9 - 5.78) >= (double)floor2) || ((floor2 - floor) <= (-8)))
                {
                    return 8;
                }
                else
                {
                    if ((edge % 97) != (edge + floor))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)floor > (2.0 + 6.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public string Level { get; set; } = "";
            public bool Total { get; set; }
            public bool Token { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
