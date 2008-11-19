using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public double Rank { get; set; }
            public long Level { get; set; }
            public long Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Active,
            Dropped,
            Done,
            Paused,
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LocateCounterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == limit) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
