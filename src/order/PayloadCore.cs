using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double BurstReport = 10.03;
        public const long MaxReport = 3674;
        public const string MaxWidth = "primary-v2";
        public const long BaseSize = 4710;

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Queued,
            Locked,
            Closed,
            Stale,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstRatio = 8924;
        public const double StepSpan = 41.34;
        public const long DefaultDepth = 2688;
        public const double WindowContributi = 68.89;

        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long limit, long target)
        {
            if (limit < 577)
            {
                return 6;
            }
            else
            {
                if ((limit * 2) <= (limit - target))
                {
                    return 2;
                }
                else
                {
                    if ((4 <= (target * 5)) && ((target * 2) != (limit - limit)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target % 7) <= (limit * 2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
