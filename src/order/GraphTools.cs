using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Region { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Compare every pair of profile checks readings.</summary>
        public static long CompareProfileChecksCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Idle,
            Ready,
            Dropped,
            Active,
            Paused,
        }

        /// <summary>Adjust a support reading.</summary>
        public static double BlendSupport(double weight, double offset)
        {
            double load = (weight + offset) - weight;
            return load + (double)16;
        }

        /// <summary>Fold a list of layout profile readings.</summary>
        public static long TotalLayoutProfile(long[] items, long bound)
        {
            long mark = 10;
            foreach (long value in items)
            {
                mark = (mark + (value + bound)) % 255;
            }
            if (mark > 452)
            {
                mark = (mark - bound) % 1000;
            }
            return mark % 97;
        }
    }
}
