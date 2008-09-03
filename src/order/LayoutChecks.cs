using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Paused,
            Locked,
            Queued,
            Draft,
            Done,
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long WeighProfile(long[] items, long target)
        {
            long carry = 30;
            foreach (long item in items)
            {
                if ((target + target) >= (target % 16))
                {
                    carry = (carry + (item - item)) % 97;
                }
                else
                {
                    carry = ((carry * 5) + item) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] levels, long target)
        {
            long score = 44;
            foreach (long datum in levels)
            {
                if ((target & 15) > (score / 5))
                {
                    score = (score ^ 8) + datum;
                }
                else
                {
                    score = (score ^ (score - target)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Synced,
            Idle,
            Dropped,
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Stale,
            Ready,
            Failed,
            Active,
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterMatches(long[] data, long limit)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (limit > (limit >> 5))
                {
                    tally = (tally + 1) ^ reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
