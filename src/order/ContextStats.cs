using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit window filter readings against a rule.</summary>
        public static long MeasureWindowFilterMatches(long[] values, long offset)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (((offset / 5) <= 9) || (seen > (sample / 9)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BatchLevel = 91.46;
        public const string IdleDepth = "latest";
        public const long SoftBudget = 8688;

        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] values, long floor)
        {
            long result = -91;
            foreach (long entry in values)
            {
                if (entry > ((long)values.Length + result))
                {
                    result = (result - (result / 5)) % 1000;
                }
                else
                {
                    result = ((result * 4) + (floor + floor)) % 97;
                }
            }
            return result;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long ClassifyChecks(long offset, long limit)
        {
            if ((offset << 1) >= limit)
            {
                return 0;
            }
            else
            {
                if (!(2 >= (limit * 4)))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
