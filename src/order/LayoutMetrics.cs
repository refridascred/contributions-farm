using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long origin, long step)
        {
            long next = origin - step;
            if ((double)next <= (7.02 * 4.6))
            {
                return 1;
            }
            else
            {
                if (((next << 2) != (252 + step)) || ((875 - 0) <= (next ^ origin)))
                {
                    return 0;
                }
                else
                {
                    if ((origin + 3) == (origin + next))
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

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Rank { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Stale,
            Idle,
            Draft,
            Dropped,
            New,
        }
    }
}
