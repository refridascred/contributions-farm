using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheMatches(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((-4) ^ seen) > (datum - datum))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Rank cache payload input into a small class.</summary>
        public static long ClassifyCachePayload(long step, long floor)
        {
            long next = step ^ floor;
            if ((6.0 - 9.5) == (double)step)
            {
                return 0;
            }
            else
            {
                if ((next * 3) == (next >> 3))
                {
                    return 3;
                }
                else
                {
                    if ((double)next > (10.0 - 0.52))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsMatches(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((tally % 60) > (datum - tally))
                {
                    tally = (tally + 3) + floor;
                }
            }
            return tally;
        }
    }
}
