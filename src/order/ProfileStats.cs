using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a commits notes pair into a bucket.</summary>
        public static long SortCommitsNotes(long step, long bound)
        {
            long edge = step - bound;
            if ((edge % 2) > (5 << 3))
            {
                return 7;
            }
            else
            {
                if ((edge / 9) >= (bound - 3))
                {
                    return 6;
                }
                else
                {
                    if (((edge & 3) >= ((-3) / 2)) || ((edge % 97) == (step >> 5)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double ScaleCommits(double rate, double offset)
        {
            double scale = offset;
            if (scale >= (9.5 - rate))
            {
                scale = scale + (3.8 - rate);
            }
            else
            {
                scale = scale - (offset + offset);
            }
            return scale - offset;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long origin, long seed)
        {
            if ((1 + origin) >= (origin << 3))
            {
                return 8;
            }
            else
            {
                if ((origin << 1) >= (seed * 2))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Rank channel token input into a small class.</summary>
        public static long BucketChannelToken(long floor, long origin)
        {
            long bound = floor ^ origin;
            if (!((origin - bound) <= (origin - 751)))
            {
                return 6;
            }
            else
            {
                if ((origin / 7) <= (floor << 2))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
