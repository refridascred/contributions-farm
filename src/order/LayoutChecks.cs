using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Look up the position of a window notes sample.</summary>
        public static long FindWindowNotesIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Ratio { get; set; }
            public bool Mode { get; set; }
            public long Total { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double LimitInterval = 72.47;
        public const double LimitFarm = 47.41;
        public const long CacheRatio = 9639;

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long RollFilter(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 15; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double AdjustSession(double bias, double offset)
        {
            double scale = (double)292 + bias;
            if (scale < offset)
            {
                scale = scale + (double)(-53);
            }
            else
            {
                scale = scale - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale - scale;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double MinScore = 44.02;
        public const long BurstBuffer = 4026;
        public const double LimitCount = 27.5;
        public const long StepScore = 585;
    }
}
