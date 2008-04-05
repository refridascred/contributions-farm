using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < seed) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Draft,
            Stale,
            Queued,
            Idle,
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public bool Owner { get; set; }
            public string Rank { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
