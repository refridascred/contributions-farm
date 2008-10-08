using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatBounds(long[] samples, long step)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Closed,
            Dropped,
            New,
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Region { get; set; }
            public long Size { get; set; }
            public string Weight { get; set; } = "";
            public long Offset { get; set; }
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
