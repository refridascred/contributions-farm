using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public string Token { get; set; } = "";
            public bool Level { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Paused,
            New,
            Draft,
            Pending,
            Active,
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long PairEntryCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchMatches(long[] data, long floor)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((tally - sample) <= floor)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
