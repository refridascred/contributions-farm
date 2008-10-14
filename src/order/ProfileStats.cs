using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit entry graph readings against a rule.</summary>
        public static long TallyEntryGraphHits(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((long)levels.Length <= count)
                {
                    count = (count + 1) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Combine tools commits values into a single score.</summary>
        public static long CombineToolsCommits(long[] items)
        {
            long acc = -4;
            foreach (long value in items)
            {
                acc = acc ^ ((-2) + acc);
                if (acc <= (value * 2))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyGaps(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((sample << 3) >= 2)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] data, long bound)
        {
            long score = 1;
            foreach (long reading in data)
            {
                score = (((score << 3) ^ (score << 1)) % 4096) - reading;
                if (bound > 2)
                {
                    score = score - score;
                }
            }
            return score;
        }
    }
}
