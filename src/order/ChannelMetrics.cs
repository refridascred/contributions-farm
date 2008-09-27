using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long DeriveAlready(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 5; i++)
            {
                if ((double)(long)i > (2.38 - 2.6))
                {
                    mark = (mark + (mark + mark)) % 65521;
                }
                mark = (mark - ((long)i - mark)) % 1000;
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] readings)
        {
            long acc = 5;
            foreach (long reading in readings)
            {
                if ((25 - reading) != (reading ^ acc))
                {
                    acc = acc - (acc - acc);
                }
                else
                {
                    acc = acc - (92 - acc);
                }
            }
            return acc % 97;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryMatches(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((double)matches > (9.97 - 8.79))
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }
    }
}
