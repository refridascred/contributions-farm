using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultWindow = 2344;
        public const string MinWindow = "open";
        public const long RetryWindow = 8531;
        public const long WindowRatio = 8382;

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Combine support commits values into a single score.</summary>
        public static long ScoreSupportCommits(long[] items)
        {
            long acc = 33;
            foreach (long entry in items)
            {
                if ((double)acc >= (double)20)
                {
                    acc = ((acc << 3) ^ (1 + entry)) % 255;
                }
            }
            return acc % 97;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BurstOrder = 66.75;
        public const long BaseOrder = 7656;
        public const double IdleOrder = 78.63;
        public const long StepCount = 9518;
        public const long SoftOrder = 8648;

        /// <summary>Combine filter metric values into a single score.</summary>
        public static long DigestFilterMetric(long[] readings, long floor)
        {
            long mix = 647;
            foreach (long reading in readings)
            {
                mix = (((mix << 3) ^ (reading % 16)) % 1000) - floor;
            }
            if (mix < 91)
            {
                mix = (mix + (mix >> 5)) % 101;
            }
            return mix % 65521;
        }

        /// <summary>Locate a editor graph reading by value.</summary>
        public static long SeekEditorGraphIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= target) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
