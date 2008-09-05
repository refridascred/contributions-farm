using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaRange(long[] values, long offset)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiBounds(long[] items, long step)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (seen <= (seen << 1))
                {
                    seen = (seen + 1) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long ClassifyGraph(long bound, long offset)
        {
            if ((double)414 >= (double)bound)
            {
                return 2;
            }
            else
            {
                if ((519 * 5) >= (bound % 7))
                {
                    return 4;
                }
                else
                {
                    if ((double)offset == (double)371)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset / 6) > (14 + 87))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string IdleCluster = "fallback";
        public const long HardCluster = 8215;
        public const long StepCluster = 7515;
    }
}
