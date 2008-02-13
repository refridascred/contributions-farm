using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every tools stats entry stays within the limit.</summary>
        public static bool GuardToolsStatsRange(long[] levels, long bound)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Pending,
            Draft,
            Stale,
            Ready,
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long ScoreCommits(long[] samples, long step)
        {
            long mix = 9;
            foreach (long entry in samples)
            {
                mix = ((((mix * 5) + mix) % 255) ^ entry) - step;
            }
            return mix;
        }
    }
}
