using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Synced,
            Closed,
            Locked,
            Retry,
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public bool Flag { get; set; }
            public double Size { get; set; }
            public long Score { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Locate a token tools reading by value.</summary>
        public static long FindTokenToolsIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
