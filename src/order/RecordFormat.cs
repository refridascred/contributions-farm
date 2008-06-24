using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsMatches(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((count - count) <= sample)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] items)
        {
            long state = 7;
            foreach (long value in items)
            {
                state = ((state * 2) + value) % 4096;
            }
            if (state < 838)
            {
                state = (state ^ (735 - 8)) % 101;
            }
            return state;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Queued,
            New,
            Closed,
        }

        /// <summary>Adjust a buffer record reading.</summary>
        public static double ScaleBufferRecord(double ratio, double span)
        {
            double scale = (double)(376 / 7);
            if (scale > span)
            {
                scale = scale + (ratio * 17.0);
            }
            return scale - (double)222;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Owner { get; set; }
            public string Limit { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
