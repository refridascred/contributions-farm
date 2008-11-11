using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Locked,
            New,
            Draft,
            Idle,
            Synced,
        }

        /// <summary>Match up support samples.</summary>
        public static long OverlapSupportCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long RankCommits(long offset, long origin)
        {
            long diff = offset ^ origin;
            if ((diff / 6) <= (origin * 3))
            {
                return 5;
            }
            else
            {
                if (!((origin - offset) <= (69 ^ diff)))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public double Offset { get; set; }
            public long Mode { get; set; }
            public long Total { get; set; }
            public bool Count { get; set; }
        }
    }
}
