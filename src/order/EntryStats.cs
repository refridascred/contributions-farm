using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Idle,
            Locked,
            New,
            Pending,
            Closed,
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Paused,
            Ready,
            Locked,
            Synced,
            Pending,
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
