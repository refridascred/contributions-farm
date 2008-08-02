using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphMatches(long[] readings, long step)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((step - entry) >= entry)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitChannel = 8936;
        public const long IdleChannel = 7503;
        public const long MinWidth = 7308;

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Ready,
            Done,
            Draft,
            New,
            Locked,
        }
    }
}
