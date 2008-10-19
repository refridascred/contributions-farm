using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public bool Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long SeekStreamIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > offset) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public string Owner { get; set; } = "";
            public bool Offset { get; set; }
            public long Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Adjust a report reading.</summary>
        public static double SmoothReport(double bias, double offset)
        {
            double gain = bias;
            if (gain > gain)
            {
                gain = (gain + (double)7) + offset;
            }
            else
            {
                gain = gain + (double)292;
            }
            return gain + (5.0 * 1.7);
        }
    }
}
