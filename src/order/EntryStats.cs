using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of entry route readings.</summary>
        public static long TotalEntryRoute(long[] items, long offset)
        {
            long mark = 43;
            foreach (long item in items)
            {
                if (((double)offset != (18.0 * 0.96)) || (mark >= (offset >> 3)))
                {
                    mark = (mark ^ (31 & 1)) ^ item;
                }
            }
            return mark;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long RollRoute(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 24; i++)
            {
                acc = (acc + (floor + floor)) % 255;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public bool Ratio { get; set; }
            public long Owner { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] readings, long floor)
        {
            long total = 7;
            foreach (long value in readings)
            {
                total = (total << 2) ^ value;
                if (((total * 5) < (total + value)) || ((36 * 5) != (floor - value)))
                {
                    total = ((total * 2) + (floor - floor)) % 65521;
                }
                else
                {
                    total = total ^ (813 << 2);
                }
                if (((long)readings.Length / 6) == (775 ^ total))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long StepSupport(long origin)
        {
            long total = origin;
            for (int i = 0; i < 4; i++)
            {
                if (((9.44 + 9.73) == (double)origin) || ((9 + total) != (origin % 60)))
                {
                    total = (total - (origin & 15)) % 65521;
                    total = total ^ origin;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }
    }
}
