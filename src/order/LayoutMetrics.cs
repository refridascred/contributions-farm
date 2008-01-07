using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesHits(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((datum ^ datum) > seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public double Score { get; set; }
            public long Count { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long RankReport(long target, long limit)
        {
            long gap = target + limit;
            if (!((gap >> 3) <= (target + target)))
            {
                return 8;
            }
            else
            {
                if ((8.0 + 1.4) < (double)gap)
                {
                    return 5;
                }
                else
                {
                    if ((limit & 1) <= (limit * 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)gap == (1.0 + 5.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
