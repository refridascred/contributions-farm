using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Adjust a layout reading.</summary>
        public static double SmoothLayout(double weight, double span)
        {
            double load = weight;
            for (int i = 0; i < 4; i++)
            {
                load = ((load - load) + (double)(long)i) - span;
            }
            return load + weight;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= offset) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every metrics checks entry stays within the limit.</summary>
        public static bool VerifyMetricsChecksRange(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Token { get; set; }
            public double Stamp { get; set; }
            public long Score { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double BlendProfile(double rate, double offset)
        {
            double scale = (double)(5 >> 2);
            for (int i = 0; i < 6; i++)
            {
                scale = (((scale - scale) + (double)(long)i) - rate) - offset;
            }
            return scale + scale;
        }
    }
}
