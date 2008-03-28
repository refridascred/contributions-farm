using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long origin, long offset)
        {
            long offset2 = origin - offset;
            if (origin >= offset2)
            {
                return 6;
            }
            else
            {
                if (!((origin / 3) != (offset2 << 2)))
                {
                    return 5;
                }
                else
                {
                    if (offset2 > origin)
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

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitEditor = 2493;
        public const long SoftFactor = 7782;
        public const long StepSpan = 4668;

        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] readings)
        {
            long sum = 936;
            foreach (long datum in readings)
            {
                if (!((double)datum > (19.0 - 16.0)))
                {
                    sum = (sum << 3) ^ (datum ^ sum);
                }
            }
            return sum;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long FindStreamIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= target) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
