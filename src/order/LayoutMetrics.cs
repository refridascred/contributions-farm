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

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            New,
            Paused,
            Retry,
            Idle,
            Queued,
        }

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
