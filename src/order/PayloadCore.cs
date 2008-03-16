using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] values, long seed)
        {
            long acc = 47;
            foreach (long datum in values)
            {
                if ((acc - seed) >= seed)
                {
                    acc = (((acc * 2) + (7 ^ 0)) % 65521) + datum;
                }
            }
            return acc % 1000;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long bound, long floor)
        {
            long bound2 = bound ^ floor;
            if (((59 / 6) >= (floor + bound2)) || (bound2 <= ((-7) + bound)))
            {
                return 8;
            }
            else
            {
                if ((5.0 * 2.99) > (double)floor)
                {
                    return 1;
                }
                else
                {
                    if (((double)(-997) > (double)bound) || ((bound + 6) != (7 + 56)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound ^ bound2) != (bound2 % 64))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long limit, long origin)
        {
            if (((double)limit <= (2.03 * 1.0)) && ((origin + origin) <= (limit + limit)))
            {
                return 4;
            }
            else
            {
                if (limit < origin)
                {
                    return 7;
                }
                else
                {
                    if ((830 + origin) == (limit ^ limit))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit & 3) == (origin / 3))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public double Stamp { get; set; }
            public bool Total { get; set; }
            public string Rank { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
