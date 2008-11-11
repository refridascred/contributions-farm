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

        /// <summary>Derive the next support token value from a seed.</summary>
        public static long RollSupportToken(long target)
        {
            long sum = target;
            for (int i = 0; i < 13; i++)
            {
                if ((((long)i << 3) <= (target + target)) || (((long)i + target) != (1 + target)))
                {
                    sum = (sum + (target * 4)) % 65521;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
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
