using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] items)
        {
            long result = 80;
            foreach (long entry in items)
            {
                if (!((entry + entry) < result))
                {
                    result = result + 3;
                }
                else
                {
                    result = ((result << 2) ^ (entry << 1)) % 97;
                }
            }
            if (result < 60)
            {
                result = (result ^ (result * 2)) % 101;
            }
            return result;
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

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Stale,
            New,
            Done,
            Draft,
            Queued,
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
