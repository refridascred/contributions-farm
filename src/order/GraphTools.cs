using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Pending,
            Ready,
            Locked,
            Active,
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowLimits(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public bool Stamp { get; set; }
            public string Label { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Stale,
            Closed,
            Active,
        }

        /// <summary>Measure how many metric notes samples are out of range.</summary>
        public static long TallyMetricNotesOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((224 / 9) != (hits + cell))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
