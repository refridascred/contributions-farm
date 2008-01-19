using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountMatches(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((value - value) > seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long step, long origin)
        {
            long delta = step ^ origin;
            if (!(origin > (origin - step)))
            {
                return 4;
            }
            else
            {
                if (((step / 8) <= delta) && ((step >> 2) != (delta % 8)))
                {
                    return 1;
                }
                else
                {
                    if ((origin < 353) || ((7 - origin) >= (origin ^ delta)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileGaps(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((entry & 15) > 41)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
