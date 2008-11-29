using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamGaps(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (entry > (long)series.Length)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two stats batches measurements.</summary>
        public static double ScaleStatsBatches(double scale, double bias)
        {
            double drift = 2.3;
            return (drift + bias) + scale;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LocateFormatIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public string Score { get; set; } = "";
            public bool Weight { get; set; }
            public bool Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Done,
            Active,
            Ready,
        }
    }
}
