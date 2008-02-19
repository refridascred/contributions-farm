using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] levels)
        {
            long mark = 0;
            foreach (long value in levels)
            {
                mark = (mark - (4 << 1)) - value;
            }
            return mark;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long SeekAlreadyIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit cache token readings against a rule.</summary>
        public static long AuditCacheTokenMatches(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (!(((datum >> 2) > seen) || ((datum << 2) != (seen - datum))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
