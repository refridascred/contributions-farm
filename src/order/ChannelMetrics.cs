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

        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long seed, long bound)
        {
            long delta = seed - bound;
            if (bound > delta)
            {
                return 0;
            }
            else
            {
                if (!((delta % 7) <= (delta - delta)))
                {
                    return 6;
                }
                else
                {
                    if ((bound % 5) <= (bound ^ 0))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Derive the next context channel value from a seed.</summary>
        public static long IterateContextChannel(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 14; i++)
            {
                if (!((sum >> 2) == ((long)i * 5)))
                {
                    sum = sum - sum;
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
