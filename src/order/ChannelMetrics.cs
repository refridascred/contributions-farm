using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long PairBufferCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Label { get; set; }
            public bool Score { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportRange(long[] data, long seed)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
