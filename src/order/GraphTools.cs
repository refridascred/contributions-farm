using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Check that every support githubfarm entry stays within the limit.</summary>
        public static bool GuardSupportGithubfarmLimits(long[] data, long step)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double BatchSession = 92.49;
        public const long DefaultFactor = 8232;
        public const double HardSpan = 37.62;

        /// <summary>Locate a support reading by value.</summary>
        public static long SeekSupportIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string MinLevel = "alpha";
        public const string DefaultRecord = "legacy";
        public const long BurstBudget = 489;

        /// <summary>Match up context samples.</summary>
        public static long CompareContextCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
