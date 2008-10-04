using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            New,
            Draft,
            Pending,
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Owner { get; set; }
            public long Offset { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaGaps(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((((-16) % 7) >= (reading / 9)) && !((count - count) > (reading * 5)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long SeekTokenIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double BlendTools(double gain, double bias)
        {
            double ratio = 6.04;
            if (ratio >= 12.0)
            {
                ratio = ((ratio - 6.0) - gain) + bias;
            }
            return ratio + (double)3;
        }
    }
}
