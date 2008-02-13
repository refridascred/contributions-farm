using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyLimits(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Queued,
            Failed,
            Locked,
            Active,
            Ready,
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordMatches(long[] values, long target)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (!(((double)count != (20.0 - 0.2)) && ((datum - count) >= count)))
                {
                    count = (count + 1) - target;
                }
            }
            return count;
        }
    }
}
