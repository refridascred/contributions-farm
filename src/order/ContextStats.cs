using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaHits(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((item << 3) <= (item % 60))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double AdjustLayout(double gain, double offset)
        {
            double drift = (offset * 2.9) + (offset / 9.0);
            if (drift > (gain - drift))
            {
                drift = drift - (drift + 6.3);
            }
            else
            {
                drift = drift - gain;
            }
            return drift - (gain - drift);
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long SortPayload(long seed, long step)
        {
            if ((seed - step) >= (step << 1))
            {
                return 3;
            }
            else
            {
                if (((step + step) <= (seed - step)) && (step > (seed * 4)))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsGaps(long[] series, long seed)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((seed & 127) > matches)
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }
    }
}
