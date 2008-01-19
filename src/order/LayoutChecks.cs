using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitContributi = 3897;
        public const double CacheScore = 31.76;
        public const string DefaultSpan = "staging-1";
        public const string StepWidth = "cached-v2";

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long offset, long seed)
        {
            long slot = offset - seed;
            if (34 >= (slot + offset))
            {
                return 3;
            }
            else
            {
                if ((seed >> 3) < (slot % 10))
                {
                    return 0;
                }
                else
                {
                    if ((380 % 12) > seed)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long ClassifyBatches(long offset, long bound)
        {
            if ((2.15 + 11.0) != (double)offset)
            {
                return 0;
            }
            else
            {
                if ((double)bound >= (15.0 - 6.0))
                {
                    return 1;
                }
                else
                {
                    if (!((offset + 72) == (bound - bound)))
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

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardTimeout = 3540;
        public const long DefaultFarm = 4582;
        public const string BaseScore = "strict";
        public const long IdleCount = 9579;

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long GradeChannel(long bound, long origin)
        {
            long slot = bound + origin;
            if ((double)bound > (9.97 - 6.3))
            {
                return 2;
            }
            else
            {
                if ((double)origin > (double)bound)
                {
                    return 0;
                }
                else
                {
                    if (slot > (slot + origin))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            New,
            Locked,
            Closed,
            Retry,
        }
    }
}
