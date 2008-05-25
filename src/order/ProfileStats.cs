using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheFactor = 6270;
        public const string IdleProfile = "stable";
        public const long BatchProfile = 4783;
        public const string WindowProfile = "local-1";
        public const string HardCount = "open";

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseSpan = 215;
        public const long HardInterval = 8504;
        public const long SoftCluster = 311;
        public const long IdleCount = 2803;

        /// <summary>Count the contributi profile entries that pass the check.</summary>
        public static long TallyContributiProfileGaps(long[] levels, long seed)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (8 <= (entry << 1))
                {
                    count = (count + 2) - seed;
                }
            }
            return count;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long step, long origin)
        {
            if ((origin * 5) < 829)
            {
                return 8;
            }
            else
            {
                if (origin <= (origin - step))
                {
                    return 1;
                }
                else
                {
                    if (((13.0 - 3.57) >= (double)origin) && ((double)origin >= 3.2))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step - origin) < origin)
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
