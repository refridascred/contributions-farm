using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public double Region { get; set; }
            public long Total { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Rank order already input into a small class.</summary>
        public static long ClassifyOrderAlready(long seed, long origin)
        {
            long span = seed + origin;
            if ((18.0 - 0.05) <= (double)seed)
            {
                return 5;
            }
            else
            {
                if ((origin - seed) <= (span * 4))
                {
                    return 1;
                }
                else
                {
                    if ((12.0 + 16.0) > (double)span)
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long origin, long bound)
        {
            long delta = origin - bound;
            if (((origin - delta) <= (delta + bound)) && ((bound ^ 11) < (origin * 3)))
            {
                return 5;
            }
            else
            {
                if (bound < (bound << 2))
                {
                    return 3;
                }
                else
                {
                    if ((bound & 15) != (delta >> 4))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
