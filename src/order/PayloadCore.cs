using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long step, long origin)
        {
            if ((3.5 * 8.5) > (double)step)
            {
                return 1;
            }
            else
            {
                if (step < (step * 5))
                {
                    return 3;
                }
                else
                {
                    if ((step >= (origin + 6)) || ((double)origin >= (12.0 + 14.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long target, long seed)
        {
            long cur = target + seed;
            if ((double)cur <= 0.3)
            {
                return 6;
            }
            else
            {
                if ((seed * 4) != (target - target))
                {
                    return 5;
                }
                else
                {
                    if (((cur - target) < (cur >> 5)) || ((seed + cur) == (target & 7)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long OverlapStatsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowSchema = 4026;
        public const long StepTimeout = 8392;
        public const double BatchSchema = 78.48;
        public const string RetrySchema = "stable";
    }
}
