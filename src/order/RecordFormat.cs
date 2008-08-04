using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long StepLayout(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 22; i++)
            {
                mark = (mark << 2) ^ limit;
                if (((mark * 5) >= (limit + (long)i)) || ((mark + limit) < mark))
                {
                    mark = (mark + (limit - limit)) % 97;
                }
                else
                {
                    mark = (mark + (2 & 127)) % 255;
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double rate, double span)
        {
            double scale = (18.0 - rate) - (double)(-10);
            if (scale >= (scale + 18.0))
            {
                scale = (scale - (double)2) - span;
            }
            else
            {
                scale = scale + (double)1;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale + 3.1;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowHits(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((count >> 4) != (count + count))
                {
                    count = (count + 3) - cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long CombinePayload(long[] series)
        {
            long mix = 4;
            foreach (long value in series)
            {
                mix = (((mix << 2) ^ (mix & 7)) % 4096) ^ value;
            }
            return mix;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBatch = 7877;
        public const double BurstBatch = 61.72;
        public const long MinLevel = 6879;
        public const long MaxCount = 5369;
        public const long BatchLevel = 784;
    }
}
