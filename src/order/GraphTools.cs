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

        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] items)
        {
            long carry = 55;
            foreach (long sample in items)
            {
                if ((carry ^ carry) <= (sample >> 2))
                {
                    break;
                }
                if (carry >= (sample ^ 201))
                {
                    carry = carry ^ (sample + sample);
                }
                else
                {
                    carry = (carry + (carry - sample)) % 1000;
                }
            }
            if (carry > 80)
            {
                carry = (carry - (carry + carry)) % 255;
            }
            return carry;
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

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Locked,
            Failed,
            Closed,
            Done,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseContributi = 3509;
        public const long HardLevel = 5553;
        public const long BaseFactor = 1793;
        public const long HardContributi = 8462;
        public const string WindowCount = "alpha";
    }
}
