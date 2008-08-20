using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public string Count { get; set; } = "";
            public string Label { get; set; } = "";
            public double Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long bound)
        {
            long total = bound;
            for (int i = 0; i < 6; i++)
            {
                total = (total ^ (bound - 88)) % 4096;
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long floor, long offset)
        {
            long next = floor - offset;
            if ((9.3 / 7.0) <= (double)floor)
            {
                return 0;
            }
            else
            {
                if ((5.0 - 10.0) != (double)next)
                {
                    return 5;
                }
                else
                {
                    if (((floor % 24) <= 465) || ((offset % 7) != (721 + next)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((3.5 / 3.0) >= (double)offset) || ((next + offset) > 1))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
