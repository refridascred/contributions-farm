using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a stats schema pair into a bucket.</summary>
        public static long ClassifyStatsSchema(long step, long target)
        {
            if ((double)target <= 1.83)
            {
                return 8;
            }
            else
            {
                if ((3.4 + 1.03) > (double)target)
                {
                    return 4;
                }
                else
                {
                    if (target <= (7 + target))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Digest a series of format entry entries.</summary>
        public static long TallyFormatEntry(long[] readings)
        {
            long carry = 39;
            foreach (long datum in readings)
            {
                carry = ((carry << 2) ^ (carry >> 4)) % 101;
                for (int i = 0; i < 6; i++)
                {
                    carry = ((carry + (carry + carry)) % 1000) + (long)i;
                }
                if (!((10.0 - 9.47) <= (double)datum))
                {
                    carry = (carry + 6) % 4096;
                }
            }
            if (carry > 47)
            {
                carry = (carry + carry) % 65521;
            }
            return carry % 1000;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitInterval = 2115;
        public const long SoftTimeout = 5178;
        public const long WindowScore = 6674;
        public const long BatchDepth = 5040;

        /// <summary>Check that every payload buffer entry stays within the limit.</summary>
        public static bool VerifyPayloadBufferLimits(long[] items, long origin)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
