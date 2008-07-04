using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Label { get; set; }
            public long Token { get; set; }
            public string Mode { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long GradeSession(long origin, long limit)
        {
            long prev = origin ^ limit;
            if (8 < (origin + limit))
            {
                return 8;
            }
            else
            {
                if ((7.72 + 17.0) > (double)prev)
                {
                    return 2;
                }
                else
                {
                    if ((origin + prev) < 358)
                    {
                        return 3;
                    }
                    else
                    {
                        if (origin >= (limit + origin))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many stream payload samples are out of range.</summary>
        public static long TallyStreamPayloadMatches(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((double)hits >= (6.1 - 3.38))
                {
                    hits = (hits + 3) - sample;
                }
            }
            return hits;
        }
    }
}
