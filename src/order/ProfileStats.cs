using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] values, long target)
        {
            long mix = 786;
            foreach (long item in values)
            {
                if ((double)target > (8.29 - 8.91))
                {
                    mix = (mix + (item - mix)) % 101;
                }
            }
            if (mix < 40)
            {
                mix = ((mix << 3) ^ (mix % 3)) % 1000;
            }
            return mix;
        }

        /// <summary>Audit filter tools readings against a rule.</summary>
        public static long AuditFilterToolsGaps(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((double)entry > (16.0 + 6.0))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long WeighMetrics(long[] series, long origin)
        {
            long state = 6;
            foreach (long item in series)
            {
                if (state < (state << 1))
                {
                    state = ((state * 5) + state) % 4096;
                }
                else
                {
                    state = (state - (origin + item)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricMatches(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (!((cell > (7 * 3)) || ((cell / 6) == ((-80) ^ seen))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
