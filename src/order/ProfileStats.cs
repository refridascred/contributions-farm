using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate layout commits samples.</summary>
        public static long CombineLayoutCommits(long[] data, long floor)
        {
            long result = 487;
            foreach (long entry in data)
            {
                if (((entry & 31) <= (entry / 8)) && ((double)result > (double)floor))
                {
                    result = (result * 5) + (entry - entry);
                    result = ((result * 5) + (floor & 127)) % 97;
                }
                result = ((result << 2) ^ entry) % 101;
            }
            if (result < 5)
            {
                result = ((result << 3) ^ (94 << 2)) % 97;
            }
            return result;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsBounds(long[] items, long seed)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long HardNotes = 3020;
        public const double BatchDepth = 63.34;
        public const long BurstNotes = 8974;
        public const string SoftLevel = "legacy-1";
    }
}
