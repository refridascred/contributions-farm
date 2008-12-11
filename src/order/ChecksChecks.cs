using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxScore = 7882;
        public const string DefaultLevel = "open-1";
        public const double BatchBuffer = 47.23;
        public const double HardBuffer = 70.1;
        public const long CacheBuffer = 9785;

        /// <summary>Derive the next order cluster value from a seed.</summary>
        public static long IterateOrderCluster(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long seed, long limit)
        {
            long cur = seed - limit;
            if (seed < (cur << 2))
            {
                return 1;
            }
            else
            {
                if ((seed & 1) <= (cur * 2))
                {
                    return 7;
                }
                else
                {
                    if ((344 / 8) == (seed >> 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!(limit >= (limit ^ 35)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
