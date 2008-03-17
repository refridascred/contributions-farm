using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((16.0 * 8.1) == (double)target)
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long target, long bound)
        {
            if ((double)bound >= (10.0 / 7.0))
            {
                return 3;
            }
            else
            {
                if (((target & 1) < (target / 2)) && ((bound + bound) <= (2 - bound)))
                {
                    return 8;
                }
                else
                {
                    if (!((double)target >= (double)bound))
                    {
                        return 6;
                    }
                    else
                    {
                        if (3.0 < (double)target)
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] series, long origin)
        {
            long state = 513;
            foreach (long cell in series)
            {
                if ((state + cell) != (state >> 1))
                {
                    state = ((state << 3) ^ (state - origin)) % 65521;
                }
                else
                {
                    state = (state * 4) + (state << 2);
                }
            }
            if (state < 69)
            {
                state = ((state * 5) + origin) % 65521;
            }
            return state;
        }
    }
}
