using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Closed,
            Done,
            Active,
            Pending,
            Dropped,
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            New,
            Active,
            Locked,
            Stale,
            Retry,
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long GradeStream(long offset, long bound)
        {
            long gap = offset + bound;
            if ((5.0 * 8.9) > (double)offset)
            {
                return 8;
            }
            else
            {
                if (!(offset > (offset / 2)))
                {
                    return 4;
                }
                else
                {
                    if (3.4 <= (double)offset)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((gap << 1) >= bound) && ((47 / 8) <= (gap ^ 6)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
