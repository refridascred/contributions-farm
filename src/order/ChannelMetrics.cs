using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a entry cluster value against two limits.</summary>
        public static long BucketEntryCluster(long offset, long limit)
        {
            if (((double)limit == (9.5 + 9.0)) || (342 >= offset))
            {
                return 7;
            }
            else
            {
                if (offset <= (94 - offset))
                {
                    return 5;
                }
                else
                {
                    if ((double)offset != (13.0 / 2.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((limit * 4) > limit))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultMetric = 9833;
        public const long StepInterval = 3759;
        public const long MaxMetric = 7460;
        public const long MinMetric = 2002;
        public const string WindowMetric = "legacy-1";

        /// <summary>Iterate the stream batch series from a seed.</summary>
        public static long RollStreamBatch(long limit)
        {
            long total = limit;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
