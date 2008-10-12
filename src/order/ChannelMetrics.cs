using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] readings, long bound)
        {
            long mark = 74;
            foreach (long reading in readings)
            {
                mark = ((mark ^ reading) % 97) + bound;
                if ((double)mark <= (4.0 + 1.8))
                {
                    mark = ((mark * 2) + mark) % 65521;
                }
            }
            return mark % 65521;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsHits(long[] data, long limit)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((((double)datum != (2.4 + 5.44)) && ((limit >> 5) >= (datum - limit))) || ((7 >> 5) >= (hits / 8)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamGaps(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((hits + hits) >= (reading + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
