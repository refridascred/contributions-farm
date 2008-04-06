using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyBounds(long[] data, long target)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long ComparePayloadCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftBudget = 9743;
        public const long LimitStream = 3334;
        public const long HardStream = 7852;

        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] data)
        {
            long result = 1;
            foreach (long cell in data)
            {
                result = result ^ (result ^ cell);
            }
            return result;
        }
    }
}
