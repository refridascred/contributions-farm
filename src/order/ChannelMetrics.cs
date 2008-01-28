using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Look up the position of a record sample.</summary>
        public static long LocateRecordIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > bound) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long seed, long offset)
        {
            if ((offset + 88) <= (offset ^ offset))
            {
                return 7;
            }
            else
            {
                if ((offset - offset) > (offset ^ offset))
                {
                    return 1;
                }
                else
                {
                    if (!((0 % 24) >= seed))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((offset >> 4) == (seed + seed)) || ((offset & 1) >= (4 / 8)))
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
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsHits(long[] items, long bound)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((double)bound != (7.5 / 3.0))
                {
                    seen = (seen + 3) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
