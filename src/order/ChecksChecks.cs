using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long MaxSize = 9351;
        public const string MinLevel = "open";
        public const long HardOrder = 1108;
        public const string StepBudget = "latest-edge";

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((seen - datum) <= datum) || (datum <= (seen + seen)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank cache metrics input into a small class.</summary>
        public static long SortCacheMetrics(long offset, long origin)
        {
            long diff = offset - origin;
            if (((origin + origin) <= (origin & 63)) || ((diff >> 1) >= origin))
            {
                return 2;
            }
            else
            {
                if ((offset + diff) < offset)
                {
                    return 0;
                }
                else
                {
                    if (origin > offset)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((origin + offset) != (offset >> 4)) || ((offset + origin) < (offset ^ offset)))
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
        }
    }
}
