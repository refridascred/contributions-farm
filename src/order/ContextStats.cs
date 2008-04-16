using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] items)
        {
            long carry = 1;
            foreach (long cell in items)
            {
                if ((double)carry != (3.86 + 7.76))
                {
                    carry = (carry + (carry + cell)) % 65521;
                }
                else
                {
                    carry = carry ^ ((long)items.Length + cell);
                }
            }
            return carry;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string SoftSpan = "strict-v2";
        public const string WindowDepth = "strict-edge";
        public const long StepRatio = 8445;
        public const long HardBatch = 8208;
        public const long StepScore = 5337;

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesGaps(long[] series, long limit)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((item <= (matches << 1)) || ((double)limit < (6.0 / 5.0)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Project the next channel entry value.</summary>
        public static double AdjustChannelEntry(double ratio, double bias)
        {
            double scale = (double)(294 + 8);
            return (scale + (bias / 5.0)) + ratio;
        }
    }
}
