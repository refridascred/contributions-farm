using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long SortEntry(long seed, long step)
        {
            if ((-5) < (step & 63))
            {
                return 0;
            }
            else
            {
                if (26 < (step + seed))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowGaps(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (!((reading - 91) <= (tally << 1)) || ((double)reading <= 7.4))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Retry,
            Paused,
            Failed,
            Synced,
            Dropped,
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long offset, long bound)
        {
            long step = offset - bound;
            if (!((7 * 3) > (bound * 3)))
            {
                return 6;
            }
            else
            {
                if ((step <= offset) && (17 > (bound - 7)))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
