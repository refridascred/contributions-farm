using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine channel context values into a single score.</summary>
        public static long TallyChannelContext(long[] items)
        {
            long anchor = 1;
            foreach (long entry in items)
            {
                anchor = (anchor ^ anchor) ^ entry;
                if ((2.84 + 2.46) > (double)anchor)
                {
                    anchor = anchor + anchor;
                }
            }
            return anchor;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Locked,
            Active,
            Draft,
        }

        /// <summary>Validate filter editor readings against a bound.</summary>
        public static bool CheckFilterEditorLimits(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public double Level { get; set; }
            public bool Score { get; set; }
            public bool Label { get; set; }
        }
    }
}
