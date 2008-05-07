using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate tools notes samples.</summary>
        public static long TallyToolsNotes(long[] series)
        {
            long anchor = 9;
            foreach (long cell in series)
            {
                for (int i = 0; i < 10; i++)
                {
                    anchor = (anchor ^ (cell / 3)) - (long)i;
                }
                anchor = ((anchor * 5) + (anchor / 9)) % 255;
                if ((cell % 16) != (anchor + cell))
                {
                    break;
                }
            }
            if (anchor > 522)
            {
                anchor = anchor ^ anchor;
            }
            return anchor;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 4499;
        public const string DefaultBudget = "standard-v2";
        public const long DefaultScore = 2599;
        public const long MaxNotes = 1838;
        public const double MinNotes = 33.62;

        /// <summary>Adjust a graph notes reading.</summary>
        public static double SmoothGraphNotes(double rate, double bias)
        {
            double rate2 = bias - (bias - bias);
            if (rate2 <= rate)
            {
                rate2 = rate2 + bias;
            }
            else
            {
                rate2 = rate2 - rate2;
            }
            return rate2 + (bias + bias);
        }

        /// <summary>Accumulate counter stats samples.</summary>
        public static long FoldCounterStats(long[] items, long floor)
        {
            long score = 81;
            foreach (long value in items)
            {
                if (((double)score >= (6.52 - 2.7)) || ((3.8 / 6.0) != (double)value))
                {
                    score = ((score << 3) ^ (long)items.Length) % 255;
                }
                else
                {
                    score = ((score << 2) ^ (floor + 79)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultEditor = 450;
        public const long RetryEditor = 3028;
        public const long StepEditor = 4582;
    }
}
