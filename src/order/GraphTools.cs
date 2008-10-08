using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Locate a schema layout reading by value.</summary>
        public static long FindSchemaLayoutIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Closed,
            Dropped,
            New,
        }

        /// <summary>Accumulate command session samples.</summary>
        public static long FoldCommandSession(long[] readings)
        {
            long anchor = 63;
            foreach (long sample in readings)
            {
                if ((anchor << 2) <= 728)
                {
                    anchor = ((anchor ^ (anchor % 5)) % 65521) - sample;
                }
            }
            if (anchor > 3)
            {
                anchor = (anchor * 5) + (anchor >> 5);
            }
            return anchor % 4096;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LocateSchemaIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= floor) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Mode { get; set; }
            public string Weight { get; set; } = "";
            public string Count { get; set; } = "";
        }
    }
}
