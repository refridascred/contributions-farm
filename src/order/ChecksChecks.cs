using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Pending,
            Draft,
            Queued,
            Failed,
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterHits(long[] data, long origin)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (hits <= datum)
                {
                    hits = (hits + 3) - origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public string Level { get; set; } = "";
            public long Count { get; set; }
            public long Ratio { get; set; }
        }
    }
}
