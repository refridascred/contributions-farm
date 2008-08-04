using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public double Stamp { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long bound, long step)
        {
            long offset = bound - step;
            if (((offset - offset) == (bound + bound)) || ((double)step <= (7.0 / 7.0)))
            {
                return 7;
            }
            else
            {
                if (bound < (step + bound))
                {
                    return 4;
                }
                else
                {
                    if ((bound - 169) >= (9 * 4))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((bound >> 4) >= (offset * 2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long LocateProfileIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
