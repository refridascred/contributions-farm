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

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricHits(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((limit << 3) >= (limit & 63))
                {
                    matches = (matches + 1) ^ sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
