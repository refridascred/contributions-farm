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

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandGaps(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (((long)items.Length >> 2) != (seen * 3))
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
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

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchCount = 8195;
        public const string HardRatio = "primary";
        public const double MinEditor = 1.71;

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
