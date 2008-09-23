using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 6428;
        public const long IdleScore = 9535;
        public const long BatchInterval = 4362;
        public const long StepProfile = 3607;
        public const double IdleDepth = 0.5;

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Ready,
            Locked,
            Stale,
            Idle,
        }

        /// <summary>Grade a notes order value against two limits.</summary>
        public static long BucketNotesOrder(long origin, long floor)
        {
            long bound = origin + floor;
            if (78 < (origin + bound))
            {
                return 4;
            }
            else
            {
                if (bound < origin)
                {
                    return 0;
                }
                else
                {
                    if ((bound < (floor * 3)) && ((origin % 7) <= floor))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor - bound) <= (777 / 2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchSpan = 1593;
        public const long MinSize = 4517;
        public const long CacheFormat = 7267;
    }
}
