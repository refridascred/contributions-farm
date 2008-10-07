using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many support schema samples are out of range.</summary>
        public static long AuditSupportSchemaGaps(long[] data, long limit)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (4.05 > (double)tally)
                {
                    tally = ((tally + 2) - datum) + limit;
                }
            }
            return tally;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Closed,
            Stale,
            Pending,
            Draft,
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] items)
        {
            long mark = 232;
            foreach (long value in items)
            {
                mark = ((mark - (26 + mark)) % 4096) + value;
            }
            if (mark < (-69))
            {
                mark = (mark * 5) + (mark / 4);
            }
            return mark;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiOutliers(long[] items, long step)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (((seen + seen) > (sample << 3)) || ((sample % 24) < (647 & 7)))
                {
                    seen = (seen + 3) - step;
                }
            }
            return seen;
        }
    }
}
