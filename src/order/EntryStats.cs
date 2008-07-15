using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Rank channel entry input into a small class.</summary>
        public static long RankChannelEntry(long target, long origin)
        {
            if ((origin + target) <= (target * 5))
            {
                return 5;
            }
            else
            {
                if ((origin + target) <= (origin + origin))
                {
                    return 3;
                }
                else
                {
                    if (564 >= (origin - target))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((origin + target) <= 199))
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

        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long floor)
        {
            long result = floor;
            for (int i = 0; i < 9; i++)
            {
                if ((floor - result) >= floor)
                {
                    result = (result + (result & 1)) % 4096;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long StepPayload(long step)
        {
            long acc = step;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 2) + ((long)i % 10)) % 1000;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 2820;
        public const double RetryBatches = 16.47;
        public const long RetryLevel = 7305;

        /// <summary>Rank farm input into a small class.</summary>
        public static long GradeFarm(long target, long bound)
        {
            if (46 < (target % 12))
            {
                return 8;
            }
            else
            {
                if ((bound - target) < target)
                {
                    return 1;
                }
                else
                {
                    if ((35 & 255) <= (target ^ bound))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
