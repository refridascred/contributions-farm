using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Compare every pair of notes record readings.</summary>
        public static long OverlapNotesRecordCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Draft,
            Synced,
            Closed,
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryOutliers(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((long)data.Length == (cell ^ 6))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ScaleEditor(double gain, double span)
        {
            double mean = (double)(4 * 5);
            if (mean <= (double)4)
            {
                mean = mean + (span + gain);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (double)3) + (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Project the next channel value.</summary>
        public static double ProjectChannel(double scale, double offset)
        {
            double ratio = offset * 3.13;
            if (ratio <= (9.0 + scale))
            {
                ratio = ratio - (8.0 * 1.0);
            }
            else
            {
                ratio = ratio - (ratio * 2.67);
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + (double)4) + (double)(long)i;
            }
            return ratio + (double)3;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Paused,
            Ready,
            Idle,
        }
    }
}
