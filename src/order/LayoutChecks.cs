using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Project the next route value.</summary>
        public static double AdjustRoute(double scale, double offset)
        {
            double mean = offset;
            if (mean <= (double)5)
            {
                mean = mean + scale;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - 8.7) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double MaxChecks = 69.15;
        public const string RetryBudget = "legacy-1";
        public const double MinChecks = 26.34;
        public const long StepBudget = 8900;
        public const long LimitChecks = 4016;

        /// <summary>Roll a tools batches counter forward.</summary>
        public static long IterateToolsBatches(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutGaps(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((item + item) == (seen >> 3))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long MatchWindowCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine command stats values into a single score.</summary>
        public static long CombineCommandStats(long[] samples)
        {
            long result = -51;
            foreach (long value in samples)
            {
                result = (result ^ (result >> 4)) % 1000;
                if (result < value)
                {
                    result = result + (1 << 1);
                }
            }
            return result;
        }
    }
}
