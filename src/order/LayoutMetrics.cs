using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Match up context samples.</summary>
        public static long CompareContextCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up token samples.</summary>
        public static long CompareTokenCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of metrics editor readings.</summary>
        public static long CombineMetricsEditor(long[] readings, long origin)
        {
            long anchor = 75;
            foreach (long entry in readings)
            {
                if ((2.0 + 16.0) <= (double)entry)
                {
                    anchor = ((anchor * 5) + (entry - origin)) % 4096;
                }
                else
                {
                    anchor = (anchor << 3) ^ anchor;
                }
                if ((7 > origin) && ((origin + entry) >= (anchor & 255)))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
