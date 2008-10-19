using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Synced,
            Ready,
            Done,
            Closed,
        }

        /// <summary>Check that every route cluster entry stays within the limit.</summary>
        public static bool VerifyRouteClusterBounds(long[] items, long seed)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long CompareTokenCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((datum + datum) >= (datum ^ hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
