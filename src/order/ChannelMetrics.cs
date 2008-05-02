using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Mode { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LocateBufferIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= offset) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesMatches(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((923 << 2) >= cell)
                {
                    tally = (tally + 2) + offset;
                }
            }
            return tally;
        }
    }
}
