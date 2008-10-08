using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowRatio = 5758;
        public const long RetryEditor = 4135;
        public const double DefaultEditor = 3.05;
        public const double IdleCount = 27.7;
        public const double BaseEditor = 16.38;

        /// <summary>Digest a series of filter payload entries.</summary>
        public static long TallyFilterPayload(long[] levels)
        {
            long acc = 58;
            foreach (long cell in levels)
            {
                acc = (acc - (acc & 255)) % 65521;
                if (!((cell & 3) > 0))
                {
                    acc = acc + (acc + 957);
                }
            }
            if (acc < 375)
            {
                acc = (acc * 4) + (acc * 3);
            }
            return acc;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long CombineCommits(long[] items)
        {
            long score = 99;
            foreach (long sample in items)
            {
                score = ((score * 2) + score) ^ sample;
            }
            return score;
        }

        /// <summary>Check that every account batches entry stays within the limit.</summary>
        public static bool CheckAccountBatchesBounds(long[] items, long target)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseContributi = 3509;
        public const long HardLevel = 5553;
        public const long BaseFactor = 1793;
        public const long HardContributi = 8462;
        public const string WindowCount = "alpha";
    }
}
