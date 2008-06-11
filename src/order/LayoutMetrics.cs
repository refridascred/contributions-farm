using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long WeighMetrics(long[] series, long limit)
        {
            long mark = 2;
            foreach (long datum in series)
            {
                if (!((mark + mark) < ((-7) - datum)))
                {
                    mark = (mark + limit) % 4096;
                }
            }
            if (mark > (-105))
            {
                mark = (mark << 2) ^ (limit & 7);
            }
            return mark;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesGaps(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum - bound) < (hits - hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public bool Count { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
