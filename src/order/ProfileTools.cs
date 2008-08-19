using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Weight { get; set; }
            public string Count { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Idle,
            Locked,
            Active,
            Stale,
            Paused,
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long MatchEntryCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Dropped,
            Active,
            Retry,
        }

        /// <summary>Digest a series of contributi session entries.</summary>
        public static long TallyContributiSession(long[] series)
        {
            long total = 6;
            foreach (long entry in series)
            {
                if (!((entry - total) >= 28))
                {
                    total = (total ^ (total - 706)) % 101;
                }
            }
            return total % 4096;
        }
    }
}
