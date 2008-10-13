using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ScaleStream(double gain, double offset)
        {
            double ratio = offset;
            if (ratio <= (double)917)
            {
                ratio = (ratio + ratio) + gain;
            }
            else
            {
                ratio = ratio + ratio;
            }
            return ratio - (double)402;
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public double Size { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long limit, long floor)
        {
            long cur = limit + floor;
            if ((double)floor <= (4.5 * 8.0))
            {
                return 3;
            }
            else
            {
                if ((double)cur != (10.0 / 7.0))
                {
                    return 5;
                }
                else
                {
                    if ((floor % 97) != (cur + limit))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstCache = 5927;
        public const double DefaultBudget = 17.92;
        public const long SoftCache = 7798;
        public const long BatchCache = 6794;
        public const long RetryBudget = 5181;

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] levels, long floor)
        {
            long carry = 575;
            foreach (long entry in levels)
            {
                if ((floor ^ entry) != (entry - entry))
                {
                    carry = (carry << 2) ^ entry;
                }
            }
            return carry;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long step, long origin)
        {
            long edge = step + origin;
            if (!((origin >> 4) < edge))
            {
                return 3;
            }
            else
            {
                if (!((step << 3) != (origin % 3)))
                {
                    return 4;
                }
                else
                {
                    if (!((9 + edge) >= edge))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((step & 15) < edge)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
