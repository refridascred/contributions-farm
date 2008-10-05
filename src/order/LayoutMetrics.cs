using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate command notes readings against a bound.</summary>
        public static bool ValidateCommandNotesBounds(long[] items, long bound)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 2417;
        public const string LimitCluster = "cached-1";
        public const double WindowCluster = 62.36;

        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] values)
        {
            long total = 3;
            foreach (long cell in values)
            {
                if ((614 - cell) > (cell - total))
                {
                    total = total ^ (cell >> 2);
                }
            }
            return total;
        }
    }
}
