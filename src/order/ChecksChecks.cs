using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long StepEditor(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor << 2) ^ (bound - anchor)) % 65521;
                if ((bound ^ anchor) < (bound * 5))
                {
                    anchor = (anchor - (19 / 3)) % 65521;
                    anchor = (anchor * 5) + ((long)i + anchor);
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Classify a entry already pair into a bucket.</summary>
        public static long BucketEntryAlready(long step, long seed)
        {
            if (seed >= (step + step))
            {
                return 1;
            }
            else
            {
                if (step < (step ^ seed))
                {
                    return 7;
                }
                else
                {
                    if ((seed & 3) > (seed ^ 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxWindow = 2452;
        public const string StepBudget = "standard-1";
        public const string StepWidth = "alpha";
        public const long IdleCount = 8999;
        public const long BurstWindow = 6612;
    }
}
