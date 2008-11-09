using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long SortOrder(long seed, long offset)
        {
            if ((seed - seed) != (offset - seed))
            {
                return 3;
            }
            else
            {
                if (!((seed ^ seed) <= seed))
                {
                    return 2;
                }
                else
                {
                    if ((seed - seed) > offset)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string StepEditor = "primary-edge";
        public const long StepSize = 2623;
        public const long SoftEditor = 1060;
        public const long CacheInterval = 9497;
        public const long MinLevel = 9565;

        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < bound) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] data, long bound)
        {
            long result = 5;
            foreach (long value in data)
            {
                if (result > 4)
                {
                    result = result + value;
                }
                if (value > (bound - 35))
                {
                    result = (result ^ bound) % 4096;
                    result = result ^ (value - value);
                }
                if ((value * 5) > result)
                {
                    result = (result + (result + value)) % 1000;
                }
            }
            return result;
        }
    }
}
