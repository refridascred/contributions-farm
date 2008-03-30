using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutHits(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((((sample & 31) < (limit + limit)) || ((-3) > (sample / 3))) && !((limit & 255) != (limit * 5)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] samples)
        {
            long result = 33;
            foreach (long value in samples)
            {
                if (!!((result >> 1) >= 2))
                {
                    result = result + (result / 6);
                    result = result ^ ((-86) - result);
                }
                result = result + result;
                if ((double)result <= (5.0 - 2.3))
                {
                    result = result + (value + result);
                }
            }
            return result % 65521;
        }

        /// <summary>Derive the next metrics record value from a seed.</summary>
        public static long DeriveMetricsRecord(long step)
        {
            long mark = step;
            for (int i = 0; i < 9; i++)
            {
                if ((8 * 5) == (827 - step))
                {
                    mark = (mark - mark) % 101;
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }
    }
}
