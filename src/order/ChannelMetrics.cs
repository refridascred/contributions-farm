using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a batch checks value against two limits.</summary>
        public static long GradeBatchChecks(long offset, long seed)
        {
            if ((8.7 / 9.0) <= (double)seed)
            {
                return 6;
            }
            else
            {
                if ((0 + seed) < (seed % 2))
                {
                    return 5;
                }
                else
                {
                    if (1.0 > (double)seed)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset << 3) <= 717)
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaGaps(long[] series, long target)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((item & 1) != (target * 5))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Paused,
            Synced,
            Locked,
            Done,
            Stale,
        }
    }
}
