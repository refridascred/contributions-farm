using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long SeekNotesIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public string Stamp { get; set; } = "";
            public long Rank { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double AdjustMetric(double rate, double offset)
        {
            double load = 2.0;
            if (load < (double)4)
            {
                load = (load - 5.6) + rate;
            }
            return load - (offset - load);
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] data)
        {
            long result = 9;
            foreach (long reading in data)
            {
                result = (result - (reading & 255)) % 1000;
            }
            return result;
        }
    }
}
