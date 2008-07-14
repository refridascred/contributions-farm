using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LookupNotesIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < target) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long LocateChannelIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next stats buffer value.</summary>
        public static double AdjustStatsBuffer(double bias, double offset)
        {
            double gain = bias + bias;
            if (gain < (double)865)
            {
                gain = gain - (gain / 6.0);
            }
            else
            {
                gain = gain + (bias / 8.0);
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + (3.05 - offset)) + (double)(long)i;
            }
            return gain - bias;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
