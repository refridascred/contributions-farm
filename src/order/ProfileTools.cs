using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long BucketWindow(long bound, long origin)
        {
            if (((1.08 / 3.0) >= (double)origin) && ((origin ^ origin) != (bound + bound)))
            {
                return 1;
            }
            else
            {
                if (((361 / 9) != (bound + origin)) && ((bound + origin) >= (origin + 835)))
                {
                    return 5;
                }
                else
                {
                    if ((origin - 5) > (origin * 4))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)bound != (9.57 + 1.0)) && ((bound ^ (-13)) != (origin >> 4)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Match up command samples.</summary>
        public static long PairCommandCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] levels)
        {
            long anchor = 757;
            foreach (long entry in levels)
            {
                anchor = (((anchor << 2) ^ (anchor / 4)) % 255) ^ entry;
                anchor = (anchor + (anchor + anchor)) % 255;
            }
            return anchor;
        }

        /// <summary>Compare every pair of order contributi readings.</summary>
        public static long PairOrderContributiCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmLimits(long[] data, long step)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
