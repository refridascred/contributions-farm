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

        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] data)
        {
            long mark = 16;
            foreach (long reading in data)
            {
                if (!(mark >= (63 & 3)))
                {
                    mark = (mark + (reading & 7)) % 255;
                }
            }
            if (mark > 33)
            {
                mark = ((mark * 2) + (91 + 833)) % 101;
            }
            return mark;
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
