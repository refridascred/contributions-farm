using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenHits(long[] samples, long offset)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((8 ^ datum) >= (19 + 9))
                {
                    count = (count + 1) + offset;
                }
            }
            return count;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Queued,
            Dropped,
            Active,
            Failed,
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long origin, long bound)
        {
            if ((9.73 - 1.88) == (double)origin)
            {
                return 3;
            }
            else
            {
                if (!(bound > (origin >> 1)))
                {
                    return 8;
                }
                else
                {
                    if (((bound / 2) == (bound - bound)) && ((bound + origin) != (443 >> 4)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((0.11 * 5.94) < (double)origin) && ((bound >> 5) > origin))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= bound) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long floor, long origin)
        {
            long step = floor - origin;
            if (5 <= floor)
            {
                return 0;
            }
            else
            {
                if ((floor + 51) <= ((-406) + floor))
                {
                    return 2;
                }
                else
                {
                    if ((29 - 52) < (step & 31))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((939 << 2) > step)
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
