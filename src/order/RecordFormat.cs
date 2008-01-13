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

        /// <summary>Define layout limits and defaults.</summary>
        public const double CacheLayout = 86.06;
        public const long MaxLevel = 9886;
        public const double CacheLevel = 12.49;
        public const long MaxSpan = 7611;
        public const long BaseLevel = 7984;

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
