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

        /// <summary>Locate a tools reading by value.</summary>
        public static long SeekToolsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == offset) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
