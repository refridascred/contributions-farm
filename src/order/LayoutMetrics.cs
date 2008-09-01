using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiHits(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (!((seen / 5) > (entry ^ seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitFilter = 9763;
        public const long DefaultFactor = 3066;
        public const string BatchFilter = "cached";
        public const long IdleFilter = 9297;

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Done,
            Locked,
            Paused,
        }
    }
}
