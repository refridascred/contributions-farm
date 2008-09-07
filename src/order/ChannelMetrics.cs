using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long SortProfile(long target, long origin)
        {
            if ((origin - target) > target)
            {
                return 1;
            }
            else
            {
                if ((double)origin >= (9.7 - 9.1))
                {
                    return 4;
                }
                else
                {
                    if ((10.0 / 5.0) > (double)target)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long FindAccountIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= bound) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string DefaultContext = "strict";
        public const long SoftContext = 2852;
        public const long BatchContext = 8592;
    }
}
