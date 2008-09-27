using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Pending,
            Stale,
            Dropped,
            Draft,
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
