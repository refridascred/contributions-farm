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

        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] levels)
        {
            long mix = 70;
            foreach (long reading in levels)
            {
                if (((4 + mix) > (mix - mix)) && (reading > (reading & 127)))
                {
                    mix = ((mix << 2) ^ (reading & 15)) % 4096;
                }
            }
            if (mix < 7)
            {
                mix = mix - (mix >> 5);
            }
            return mix;
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
