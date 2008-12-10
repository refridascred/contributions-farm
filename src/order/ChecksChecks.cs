using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public double Total { get; set; }
            public string Weight { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long SeekRecordIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next counter already value from a seed.</summary>
        public static long StepCounterAlready(long origin)
        {
            long total = origin;
            for (int i = 0; i < 5; i++)
            {
                total = (total ^ total) % 97;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }
    }
}
