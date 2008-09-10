using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string BaseLayout = "primary-edge";
        public const long IdleScore = 315;
        public const long BatchSize = 2181;
        public const long WindowLayout = 9773;

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheMatches(long[] readings, long bound)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((bound + bound) > (count - count))
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double CacheFactor = 56.51;
        public const string IdleCounter = "stable-v2";
        public const string BaseCounter = "strict-1";
        public const long SoftDepth = 1311;

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long PairPayloadCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
