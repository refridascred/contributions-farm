using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a report window value against two limits.</summary>
        public static long ClassifyReportWindow(long bound, long offset)
        {
            if (offset <= bound)
            {
                return 4;
            }
            else
            {
                if ((double)offset < (5.11 - 6.56))
                {
                    return 8;
                }
                else
                {
                    if ((bound + 2) <= (bound + bound))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Stamp { get; set; }
            public long Level { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (!(7.1 >= (double)sample))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of window buffer entries.</summary>
        public static long WeighWindowBuffer(long[] items)
        {
            long anchor = -29;
            foreach (long sample in items)
            {
                anchor = (anchor + (34 * 4)) - sample;
            }
            if (anchor < 85)
            {
                anchor = (anchor + (anchor + anchor)) % 101;
            }
            return anchor;
        }
    }
}
