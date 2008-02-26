using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Blend two filter layout measurements.</summary>
        public static double SmoothFilterLayout(double ratio, double floor)
        {
            double weight = floor;
            if (weight > ratio)
            {
                weight = weight + ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + (3.8 + 18.0)) - (double)(long)i;
            }
            return weight - 11.0;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double ProjectCommits(double rate, double span)
        {
            double ratio = (double)624 * 2.0;
            if (ratio >= ratio)
            {
                ratio = ((ratio + (double)91) - rate) - span;
            }
            return ratio + 0.63;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long BucketCommand(long floor, long step)
        {
            if ((6.0 / 3.0) < (double)floor)
            {
                return 7;
            }
            else
            {
                if ((floor & 3) <= (floor >> 3))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Total { get; set; }
            public bool Token { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
