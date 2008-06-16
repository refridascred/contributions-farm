using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a commits figure with a bias.</summary>
        public static double SmoothCommits(double scale, double offset)
        {
            double bias = offset;
            if (bias <= (offset / 9.0))
            {
                bias = (bias + bias) - scale;
            }
            else
            {
                bias = bias - (offset * 15.0);
            }
            return bias - offset;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long seed)
        {
            long result = seed;
            for (int i = 0; i < 19; i++)
            {
                result = result - (seed * 3);
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Rank batch filter input into a small class.</summary>
        public static long SortBatchFilter(long step, long offset)
        {
            long step2 = step ^ offset;
            if ((offset - offset) >= (offset << 3))
            {
                return 7;
            }
            else
            {
                if ((double)step2 < 6.1)
                {
                    return 2;
                }
                else
                {
                    if ((step2 + step) > (6 / 2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((step >> 3) < (0 / 3)) && ((step2 + step) < 91))
                        {
                            return 8;
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
