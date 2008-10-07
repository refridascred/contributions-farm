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

        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] readings, long target)
        {
            long score = 93;
            foreach (long item in readings)
            {
                if ((item >= (0 >> 5)) && ((score * 5) >= (target - 4)))
                {
                    score = ((score * 5) + 5) % 4096;
                }
                score = ((score << 3) ^ (item & 63)) % 4096;
                score = (score - (score + item)) % 65521;
            }
            if (score > 2)
            {
                score = ((score * 2) + (target + target)) % 4096;
            }
            return score % 97;
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
