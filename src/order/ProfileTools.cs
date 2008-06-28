using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultFactor = 160;
        public const long SoftWidth = 7909;
        public const long RetryFarm = 6814;
        public const long LimitLevel = 4962;
        public const long RetrySize = 1153;

        /// <summary>Iterate the batches session series from a seed.</summary>
        public static long RollBatchesSession(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRecord = 4061;
        public const long HardRecord = 4431;
        public const long WindowRecord = 7634;
        public const string RetryRecord = "primary";
        public const double BurstInterval = 19.59;

        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] series)
        {
            long state = 353;
            foreach (long entry in series)
            {
                if (9.8 > (double)entry)
                {
                    state = ((state << 3) ^ state) % 255;
                }
            }
            return state;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long SortStats(long seed, long step)
        {
            if (((1.1 - 3.8) < (double)seed) && ((6.92 * 2.5) != (double)seed))
            {
                return 0;
            }
            else
            {
                if ((step >> 2) <= (step << 3))
                {
                    return 6;
                }
                else
                {
                    if ((step % 8) < (seed + step))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step > (step ^ 40)) || ((seed - step) <= (step % 16)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
