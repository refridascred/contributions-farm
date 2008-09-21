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

        /// <summary>Accumulate support samples.</summary>
        public static long TallySupport(long[] values)
        {
            long state = 0;
            foreach (long sample in values)
            {
                if (!((0.13 / 9.0) > (double)state))
                {
                    state = state + (sample + (long)values.Length);
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
