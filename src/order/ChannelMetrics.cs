using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long RankCommand(long bound, long floor)
        {
            long diff = bound ^ floor;
            if (((bound * 4) != (bound * 5)) || ((1.5 - 7.52) < (double)floor))
            {
                return 3;
            }
            else
            {
                if ((floor & 1) != (floor / 5))
                {
                    return 6;
                }
                else
                {
                    if ((double)diff >= (0.74 / 8.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((50 - floor) >= (bound / 8))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
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
