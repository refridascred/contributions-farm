using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long StepRoute = 3627;
        public const long BaseRoute = 9694;
        public const long CacheLevel = 1313;

        /// <summary>Adjust a cache reading.</summary>
        public static double BlendCache(double bias, double span)
        {
            double weight = span;
            for (int i = 0; i < 2; i++)
            {
                weight = ((weight + 3.9) - (double)(long)i) + bias;
            }
            return weight - 2.3;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long PairMetricCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public bool Region { get; set; }
            public long Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long DerivePayload(long bound)
        {
            long result = bound;
            for (int i = 0; i < 18; i++)
            {
                result = result - (938 ^ bound);
                if ((result * 5) > (result & 63))
                {
                    break;
                }
                else
                {
                    result = result + (result << 3);
                }
                result = (result - ((long)i % 5)) % 4096;
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
