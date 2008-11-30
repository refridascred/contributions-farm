using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public bool Limit { get; set; }
            public long Ratio { get; set; }
            public string Level { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public string Mode { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Rank support notes input into a small class.</summary>
        public static long RankSupportNotes(long floor, long floor2)
        {
            long next = floor - floor2;
            if ((floor + floor2) >= (6 ^ floor))
            {
                return 3;
            }
            else
            {
                if ((floor / 4) <= (0 + floor2))
                {
                    return 4;
                }
                else
                {
                    if (((double)next <= (13.0 - 6.42)) || ((2.87 - 6.0) >= (double)next))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)floor2 == (7.5 * 9.6))
                        {
                            return 0;
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
