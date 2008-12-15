using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long limit, long seed)
        {
            if ((limit > (seed + seed)) || ((seed + limit) < (limit + seed)))
            {
                return 2;
            }
            else
            {
                if ((double)seed != (7.22 - 14.0))
                {
                    return 8;
                }
                else
                {
                    if ((limit + seed) <= (limit + 219))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit - seed) > (limit >> 2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Match up entry samples.</summary>
        public static long OverlapEntryCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Paused,
            New,
            Ready,
            Active,
            Failed,
        }
    }
}
