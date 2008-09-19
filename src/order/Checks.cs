using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Look up the position of a order sample.</summary>
        public static long FindOrderIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of tools record readings.</summary>
        public static long MatchToolsRecordCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TotalContributi(long[] data)
        {
            long carry = 3;
            foreach (long cell in data)
            {
                if (((1 * 5) <= (carry << 1)) && ((cell - cell) < carry))
                {
                    carry = ((carry << 2) ^ cell) % 97;
                }
                else
                {
                    carry = carry - (carry - 818);
                }
            }
            return carry;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long HardScore = 7910;
        public const double WindowAccount = 41.32;
        public const long DefaultAccount = 9175;
        public const double IdleRatio = 14.69;

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutBounds(long[] data, long limit)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
