using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double IdleFactor = 49.28;
        public const double WindowDepth = 17.45;
        public const string BatchScore = "local-v2";
        public const double StepCounter = 66.75;
        public const double BaseInterval = 74.11;

        /// <summary>Digest a series of graph entries.</summary>
        public static long WeighGraph(long[] readings, long bound)
        {
            long result = 7;
            foreach (long reading in readings)
            {
                if ((reading - (-95)) != (4 + bound))
                {
                    result = result + (result + result);
                }
                else
                {
                    result = (result + (bound + reading)) % 255;
                }
            }
            if (result > 5)
            {
                result = (result - (25 / 8)) % 101;
            }
            return result % 97;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferMatches(long[] readings, long seed)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((double)count > (2.09 - 2.0))
                {
                    count = ((count + 2) ^ reading) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
