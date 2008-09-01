using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long DigestChecks(long[] readings)
        {
            long state = 3;
            foreach (long sample in readings)
            {
                if (((sample << 2) <= sample) || (6.1 < (double)state))
                {
                    state = (state + state) % 97;
                }
            }
            if (state > 18)
            {
                state = ((state << 3) ^ (9 + state)) % 255;
            }
            return state % 1000;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatMatches(long[] series, long limit)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)limit >= (double)773)
                {
                    seen = (seen + 3) - item;
                }
            }
            return seen;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long seed, long floor)
        {
            if (seed <= (0 - seed))
            {
                return 3;
            }
            else
            {
                if ((seed * 2) >= floor)
                {
                    return 8;
                }
                else
                {
                    if (!(seed <= 553))
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
    }
}
