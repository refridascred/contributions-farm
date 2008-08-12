using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long origin, long step)
        {
            if (((step + 19) > origin) && ((step * 2) < (step + 3)))
            {
                return 4;
            }
            else
            {
                if ((5.0 - 2.5) != (double)step)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long floor, long floor2)
        {
            long offset = floor ^ floor2;
            if ((0 > (floor / 8)) || (floor <= (floor + floor2)))
            {
                return 6;
            }
            else
            {
                if ((offset < (offset ^ offset)) && ((offset % 64) < (floor2 & 255)))
                {
                    return 1;
                }
                else
                {
                    if (11.0 >= (double)floor)
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((offset << 2) == (offset - offset)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > limit) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public bool Weight { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Check that every contributi batches entry stays within the limit.</summary>
        public static bool VerifyContributiBatchesBounds(long[] series, long origin)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
