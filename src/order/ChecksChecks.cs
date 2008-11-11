using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Stale,
            Closed,
            New,
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionRange(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long origin, long bound)
        {
            long cur = origin + bound;
            if (!((53 + bound) == (bound - origin)))
            {
                return 1;
            }
            else
            {
                if ((cur + bound) > (origin + origin))
                {
                    return 4;
                }
                else
                {
                    if ((cur / 5) >= origin)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((origin - bound) >= bound) && ((origin << 2) < (cur + cur)))
                        {
                            return 3;
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
