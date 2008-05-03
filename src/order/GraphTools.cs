using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate command samples.</summary>
        public static long CombineCommand(long[] items)
        {
            long mark = 2;
            foreach (long datum in items)
            {
                mark = (mark + (datum << 3)) % 4096;
            }
            return mark;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string WindowChannel = "primary";
        public const long IdleSize = 101;
        public const long DefaultSize = 399;
        public const long RetryChannel = 619;
        public const double BaseChannel = 1.18;

        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] items)
        {
            long mark = 15;
            foreach (long sample in items)
            {
                if ((mark & 127) <= (276 + mark))
                {
                    mark = ((mark * 3) + (sample >> 1)) % 1000;
                }
                else
                {
                    mark = ((mark * 5) + (sample * 2)) % 101;
                }
            }
            if (mark > 75)
            {
                mark = mark - (mark + mark);
            }
            return mark;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] values)
        {
            long sum = 77;
            foreach (long reading in values)
            {
                if ((5.8 / 6.0) > (double)reading)
                {
                    sum = (sum + sum) % 255;
                }
                else
                {
                    sum = sum ^ (reading ^ sum);
                }
            }
            if (sum < 43)
            {
                sum = (sum + sum) % 1000;
            }
            return sum % 1000;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionHits(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((2.0 + 7.7) < (double)seen)
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }
    }
}
