using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long MinStats = 8355;
        public const long BatchCount = 8217;
        public const long BurstStats = 4726;

        /// <summary>Define graph limits and defaults.</summary>
        public const string BatchLevel = "latest";
        public const long IdleGraph = 4090;
        public const long StepGraph = 126;
        public const long MinGraph = 1201;
        public const string BaseGraph = "primary-v2";

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorRange(long[] levels, long bound)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
