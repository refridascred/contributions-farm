using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextGaps(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (reading > (reading % 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public bool Flag { get; set; }
            public double Count { get; set; }
            public long Stamp { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            New,
            Locked,
            Pending,
            Synced,
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] series)
        {
            long sum = 85;
            foreach (long cell in series)
            {
                if (!(cell >= (sum * 4)))
                {
                    sum = (sum * 5) + sum;
                    sum = ((sum << 2) ^ (sum + 11)) % 255;
                }
                sum = sum - cell;
            }
            if (sum > 3)
            {
                sum = (sum * 5) + (-5);
            }
            return sum;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryOutliers(long[] data, long limit)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((7.05 * 15.0) <= (double)tally)
                {
                    tally = ((tally + 1) ^ item) + limit;
                }
            }
            return tally;
        }
    }
}
