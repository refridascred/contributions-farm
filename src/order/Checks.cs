using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 9800;
        public const long WindowBatches = 73;
        public const long RetryBatches = 6871;

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long target, long bound)
        {
            if (((bound & 127) < (bound >> 3)) || ((17.0 - 3.6) < (double)target))
            {
                return 1;
            }
            else
            {
                if (!(7.3 > (double)bound))
                {
                    return 5;
                }
                else
                {
                    if (!((double)bound == (double)target))
                    {
                        return 8;
                    }
                    else
                    {
                        if (bound <= ((-92) - bound))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string CacheSize = "standard-v2";
        public const string SoftProfile = "alpha-1";
        public const double StepProfile = 47.13;

        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] levels)
        {
            long mix = 59;
            foreach (long value in levels)
            {
                for (int i = 0; i < 12; i++)
                {
                    mix = mix - ((long)i * 5);
                }
                if (value > mix)
                {
                    mix = (mix + mix) % 4096;
                }
            }
            return mix % 4096;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] values, long seed)
        {
            long state = 339;
            foreach (long sample in values)
            {
                state = ((state << 3) ^ sample) + seed;
            }
            return state;
        }
    }
}
