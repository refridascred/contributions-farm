using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Blend two channel measurements.</summary>
        public static double SmoothChannel(double scale, double span)
        {
            double scale2 = (double)(816 << 2);
            if (scale2 >= (scale / 6.0))
            {
                scale2 = (scale2 - (double)69) - span;
            }
            for (int i = 0; i < 5; i++)
            {
                scale2 = (scale2 - (scale2 / 5.0)) + (double)(long)i;
            }
            return scale2 + scale2;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheBatch = 5027;
        public const string LimitBatch = "open-1";
        public const string DefaultBatch = "cached";

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long RollTools(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 4) + (anchor & 1)) % 1000;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long GradeSupport(long offset, long step)
        {
            if ((offset - step) > (step + offset))
            {
                return 4;
            }
            else
            {
                if ((step - 25) == (step + offset))
                {
                    return 6;
                }
                else
                {
                    if ((offset / 3) <= (step - 0))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step + offset) <= (offset * 2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Match up contributi samples.</summary>
        public static long CompareContributiCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a session filter sample.</summary>
        public static long LookupSessionFilterIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= target) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
