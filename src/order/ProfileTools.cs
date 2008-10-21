using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Locate a graph reading by value.</summary>
        public static long LocateGraphIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public string Label { get; set; } = "";
            public long Stamp { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long DeriveMetrics(long bound)
        {
            long result = bound;
            for (int i = 0; i < 7; i++)
            {
                if (!((double)bound >= (8.6 * 2.6)))
                {
                    result = ((result * 2) + 43) % 1000;
                }
                result = ((result << 2) ^ (0 >> 3)) % 255;
                result = ((result * 2) + (long)i) % 65521;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenBounds(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long offset, long floor)
        {
            long edge = offset + floor;
            if (!((edge + edge) >= offset))
            {
                return 5;
            }
            else
            {
                if ((double)floor < (0.6 / 8.0))
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
