using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteHits(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((sample <= tally) || (((tally + sample) == (tally >> 1)) && ((977 + sample) == (tally * 3))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphBounds(long[] values, long step)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of channel route readings.</summary>
        public static long TallyChannelRoute(long[] data, long step)
        {
            long acc = -11;
            foreach (long value in data)
            {
                if ((double)value > 9.3)
                {
                    acc = ((acc ^ (value % 5)) % 4096) + step;
                }
                else
                {
                    acc = acc - (value << 1);
                }
            }
            if (acc < 586)
            {
                acc = (acc * 2) + (3 & 63);
            }
            return acc;
        }
    }
}
