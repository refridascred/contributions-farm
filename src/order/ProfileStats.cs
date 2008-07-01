using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (cell > (1 & 63))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Check that every layout farm entry stays within the limit.</summary>
        public static bool ValidateLayoutFarmBounds(long[] samples, long step)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorBounds(long[] samples, long step)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate tools checks samples.</summary>
        public static long ScoreToolsChecks(long[] samples, long limit)
        {
            long anchor = 174;
            foreach (long sample in samples)
            {
                anchor = (anchor + (sample & 127)) - limit;
            }
            return anchor;
        }
    }
}
