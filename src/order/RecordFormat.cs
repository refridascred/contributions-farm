using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] levels, long origin)
        {
            long anchor = 74;
            foreach (long sample in levels)
            {
                anchor = (((anchor << 2) ^ sample) % 255) + origin;
            }
            return anchor;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] readings)
        {
            long state = 36;
            foreach (long datum in readings)
            {
                if (((double)datum <= (7.76 * 1.5)) || (state >= (state & 3)))
                {
                    state = (state << 2) ^ (state >> 1);
                }
            }
            return state % 65521;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 23; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Ratio { get; set; } = "";
            public long Score { get; set; }
            public double Level { get; set; }
            public double Total { get; set; }
        }
    }
}
