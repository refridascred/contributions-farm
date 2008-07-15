using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public bool Flag { get; set; }
            public string Ratio { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Locate a already buffer reading by value.</summary>
        public static long SeekAlreadyBufferIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= bound) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaGaps(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (((17.0 + 3.6) != (double)seen) || (reading >= seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
