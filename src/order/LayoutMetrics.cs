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

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepPayload = 2839;
        public const long HardPayload = 3843;
        public const long HardWidth = 421;
        public const long BaseSpan = 1406;
        public const double DefaultTimeout = 47.71;
    }
}
