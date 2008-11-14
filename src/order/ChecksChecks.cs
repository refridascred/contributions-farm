using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long FindToolsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long origin, long origin2)
        {
            if ((origin / 3) >= (177 - origin2))
            {
                return 6;
            }
            else
            {
                if (origin > (6 + origin2))
                {
                    return 7;
                }
                else
                {
                    if (!((origin2 / 7) >= (origin - origin)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Stale,
            Idle,
            Locked,
        }
    }
}
