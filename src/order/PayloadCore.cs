using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long IterateEntry(long offset)
        {
            long result = offset;
            for (int i = 0; i < 12; i++)
            {
                result = ((result << 2) ^ (offset >> 3)) % 65521;
                result = (result * 5) + result;
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinInterval = 3507;
        public const double HardBatch = 86.77;
        public const long SoftBatch = 4019;

        /// <summary>Define filter limits and defaults.</summary>
        public const string BurstFilter = "alpha-v2";
        public const long StepFilter = 6548;
        public const long HardBudget = 7866;
        public const double HardFilter = 59.41;

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long SortOrder(long step, long limit)
        {
            if (((step & 31) != (step >> 4)) || (((-223) + 27) <= limit))
            {
                return 1;
            }
            else
            {
                if (step >= (step >> 1))
                {
                    return 8;
                }
                else
                {
                    if (!((limit ^ step) > (limit - step)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((4.7 / 2.0) != (double)limit)
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
