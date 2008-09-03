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

        /// <summary>Find the first notes already entry that matches the target.</summary>
        public static long FindNotesAlreadyIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > seed) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Accumulate route samples.</summary>
        public static long TallyRoute(long[] samples)
        {
            long sum = 2;
            foreach (long value in samples)
            {
                if (((value * 4) == (sum + value)) && ((value >> 2) < (value + value)))
                {
                    sum = ((sum << 3) ^ (value & 1)) % 1000;
                }
                else
                {
                    sum = (sum ^ (value << 3)) % 255;
                }
            }
            return sum;
        }
    }
}
