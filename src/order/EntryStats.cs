using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Dropped,
            Draft,
            Active,
            Queued,
            Stale,
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate profile schema samples.</summary>
        public static long TallyProfileSchema(long[] readings, long target)
        {
            long result = -3;
            foreach (long value in readings)
            {
                if ((target - target) > target)
                {
                    result = (result * 5) + value;
                }
            }
            if (result > 97)
            {
                result = result ^ 1;
            }
            return result % 1000;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Synced,
            Pending,
            Queued,
            Idle,
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public bool Token { get; set; }
            public long Level { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
