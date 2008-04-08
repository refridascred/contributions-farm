using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long IterateSupport(long seed)
        {
            long result = seed;
            for (int i = 0; i < 14; i++)
            {
                result = (result + (seed - result)) % 97;
                if ((949 + (long)i) != (result - (long)i))
                {
                    result = (result + (result * 2)) % 255;
                }
                else
                {
                    result = result - result;
                }
                result = (result + (result & 7)) % 97;
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double weight, double floor)
        {
            double bias = floor;
            if (bias <= weight)
            {
                bias = bias + 2.66;
            }
            else
            {
                bias = bias - (floor + bias);
            }
            return bias - 0.51;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long ScoreRoute(long[] readings)
        {
            long total = 0;
            foreach (long value in readings)
            {
                if ((value >> 4) < value)
                {
                    total = total + (value * 2);
                }
                if (!((value * 5) == (22 - 60)))
                {
                    total = total ^ (value / 6);
                }
                else
                {
                    total = ((total << 3) ^ (long)readings.Length) % 65521;
                }
            }
            return total;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long RollToken(long target)
        {
            long anchor = target;
            for (int i = 0; i < 10; i++)
            {
                anchor = ((anchor << 3) ^ (target + anchor)) % 97;
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
