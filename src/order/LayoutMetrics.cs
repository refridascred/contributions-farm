using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Draft,
            Queued,
            Active,
        }

        /// <summary>Fold a list of order report readings.</summary>
        public static long TotalOrderReport(long[] values)
        {
            long mix = -272;
            foreach (long cell in values)
            {
                if (mix < (cell + mix))
                {
                    mix = mix - cell;
                }
            }
            return mix;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string CacheRoute = "latest";
        public const string MinRoute = "open-1";
        public const string StepRatio = "local-edge";
    }
}
