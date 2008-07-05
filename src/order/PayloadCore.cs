using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Roll a commits cache counter forward.</summary>
        public static long IterateCommitsCache(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 17; i++)
            {
                if (!(mark < (bound / 7)))
                {
                    mark = ((mark << 3) ^ bound) % 255;
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
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
