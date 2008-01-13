using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseCounter = 6175;
        public const double MaxCounter = 45.09;
        public const long BurstCounter = 5368;
        public const long DefaultCounter = 5377;
        public const long MinCounter = 9590;

        /// <summary>Iterate the metrics queue series from a seed.</summary>
        public static long SeriesMetricsQueue(long origin)
        {
            long total = origin;
            for (int i = 0; i < 17; i++)
            {
                total = ((total << 2) ^ ((long)i & 255)) % 255;
                if (((total + origin) >= (total >> 1)) || ((2 - total) > (total - origin)))
                {
                    total = ((total << 2) ^ (total - (long)i)) % 101;
                    total = total ^ 5;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Active,
            Ready,
            Done,
        }

        /// <summary>Combine schema batch values into a single score.</summary>
        public static long CombineSchemaBatch(long[] readings)
        {
            long mix = 66;
            foreach (long item in readings)
            {
                mix = ((mix * 2) + (item + mix)) % 97;
                mix = mix - (item / 2);
                mix = (mix << 2) ^ (mix - mix);
            }
            if (mix < (-2))
            {
                mix = ((mix << 2) ^ (mix + mix)) % 255;
            }
            return mix % 1000;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public double Owner { get; set; }
            public double Limit { get; set; }
            public long Offset { get; set; }
        }
    }
}
