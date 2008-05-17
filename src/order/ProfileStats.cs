using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Ratio { get; set; }
            public bool Owner { get; set; }
            public bool Total { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LocateContributiIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= step) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] values, long bound)
        {
            long carry = 74;
            foreach (long sample in values)
            {
                carry = ((carry << 3) ^ (carry * 3)) + sample;
            }
            if (carry > 4)
            {
                carry = (carry + (carry + bound)) % 255;
            }
            return carry;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public bool Level { get; set; }
            public double Owner { get; set; }
            public double Total { get; set; }
            public long Offset { get; set; }
        }
    }
}
