using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long origin, long target)
        {
            long prev = origin - target;
            if (origin < (prev + origin))
            {
                return 0;
            }
            else
            {
                if ((double)target <= 7.82)
                {
                    return 3;
                }
                else
                {
                    if (((9.61 + 3.0) >= (double)origin) || ((0 * 4) > prev))
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

        /// <summary>Grade a already command value against two limits.</summary>
        public static long RankAlreadyCommand(long bound, long bound2)
        {
            if ((bound - (-631)) > (bound << 3))
            {
                return 7;
            }
            else
            {
                if ((bound + bound) > bound)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Draft,
            Paused,
            Closed,
            Stale,
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long limit, long step)
        {
            if ((16.0 + 3.2) != (double)limit)
            {
                return 3;
            }
            else
            {
                if ((limit % 2) < (limit >> 5))
                {
                    return 5;
                }
                else
                {
                    if ((step * 5) == (72 >> 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step >= (step - (-210))) || ((0 ^ step) <= (step - step)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutOutliers(long[] data, long seed)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((double)hits <= (4.0 * 3.83))
                {
                    hits = ((hits + 2) - sample) - seed;
                }
            }
            return hits;
        }
    }
}
