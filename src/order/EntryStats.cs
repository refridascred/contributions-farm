using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Label { get; set; }
            public double Count { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long CompareQueueCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] levels, long target)
        {
            long mark = 859;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 4; i++)
                {
                    mark = ((mark - (reading - target)) % 1000) - (long)i;
                }
                if (((-6) >> 2) != (reading + (long)levels.Length))
                {
                    mark = (mark - 0) % 97;
                }
            }
            return mark % 65521;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public double Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Paused,
            Draft,
            Dropped,
            Locked,
            Done,
        }
    }
}
