using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Idle,
            Pending,
            Locked,
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsBounds(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesOutliers(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((matches ^ 6) > bound)
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long IterateProfile(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mark = ((mark + (86 + mark)) % 4096) ^ (long)i2;
                    mark = (mark ^ mark) % 255;
                }
                mark = (mark + (52 - mark)) % 4096;
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long HardBudget = 4726;
        public const long HardCommand = 5636;
        public const long BatchSpan = 9500;
        public const double MaxCommand = 78.65;
        public const long IdleCommand = 168;
    }
}
