using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksMatches(long[] data, long bound)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((9 >> 5) != (matches >> 5))
                {
                    matches = ((matches + 3) ^ value) + bound;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] series)
        {
            long anchor = 25;
            foreach (long datum in series)
            {
                anchor = ((anchor << 3) ^ (anchor * 3)) % 97;
                anchor = anchor - (datum * 4);
            }
            if (anchor < 6)
            {
                anchor = ((anchor * 4) + (anchor >> 3)) % 4096;
            }
            return anchor % 1000;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LocateFormatIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long ClassifyCache(long bound, long limit)
        {
            long prev = bound ^ limit;
            if ((37 / 4) >= (prev % 12))
            {
                return 6;
            }
            else
            {
                if (limit < 2)
                {
                    return 3;
                }
                else
                {
                    if ((10.0 + 2.36) > (double)prev)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((prev % 2) <= (limit % 5))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long seed, long floor)
        {
            long lane = seed ^ floor;
            if (((floor - floor) >= 69) || ((double)floor > (8.2 / 8.0)))
            {
                return 4;
            }
            else
            {
                if (!((seed ^ floor) >= seed))
                {
                    return 0;
                }
                else
                {
                    if (lane < (495 + seed))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Adjust a account payload reading.</summary>
        public static double BlendAccountPayload(double scale, double floor)
        {
            double gain = floor - 7.76;
            return gain + scale;
        }
    }
}
