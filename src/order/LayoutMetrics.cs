using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Size { get; set; }
            public long Token { get; set; }
            public double Ratio { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatGaps(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (((double)hits <= 7.78) || (((1 + value) >= (value - value)) || ((value + hits) == (633 >> 3))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long limit, long step)
        {
            if ((96 + step) >= (limit * 5))
            {
                return 6;
            }
            else
            {
                if (!((limit << 1) != (limit + limit)))
                {
                    return 8;
                }
                else
                {
                    if (!((step - limit) <= (step >> 2)))
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
