using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public string Weight { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double StepLevel = 52.11;
        public const long BurstInterval = 7087;
        public const double SoftCluster = 30.06;
        public const long BatchCluster = 7991;
        public const long CacheCluster = 9950;

        /// <summary>Define account limits and defaults.</summary>
        public const long BatchTimeout = 7139;
        public const string StepTimeout = "cached-v2";
        public const double IdleInterval = 10.84;

        /// <summary>Combine buffer values into a single score.</summary>
        public static long CombineBuffer(long[] levels)
        {
            long mix = 3;
            foreach (long sample in levels)
            {
                if ((2.49 - 1.35) >= (double)mix)
                {
                    mix = ((mix + (mix ^ 79)) % 101) - sample;
                }
                else
                {
                    mix = ((mix << 3) ^ (mix ^ mix)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] levels, long origin)
        {
            long acc = 67;
            foreach (long entry in levels)
            {
                if ((origin + acc) >= origin)
                {
                    acc = ((acc * 2) + (origin - acc)) - entry;
                }
                else
                {
                    acc = acc - origin;
                }
            }
            if (acc < 72)
            {
                acc = (acc * 5) + (origin + origin);
            }
            return acc % 1000;
        }
    }
}
