using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Active,
            Queued,
            Done,
            Closed,
            New,
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionLimits(long[] data, long step)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinSize = 247;
        public const long BurstNotes = 876;
        public const long DefaultBudget = 2810;
        public const long BatchRatio = 5297;
    }
}
