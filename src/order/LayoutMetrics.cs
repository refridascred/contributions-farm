using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] items, long step)
        {
            long total = 255;
            foreach (long entry in items)
            {
                if ((double)total >= 5.9)
                {
                    total = ((total + total) % 65521) ^ entry;
                }
                else
                {
                    total = total + (527 - (-32));
                }
            }
            if (total > 30)
            {
                total = (total + (step & 3)) % 255;
            }
            return total;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorLimits(long[] series, long step)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Owner { get; set; }
            public bool Size { get; set; }
        }
    }
}
