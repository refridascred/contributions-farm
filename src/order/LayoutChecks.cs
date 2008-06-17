using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long StepChannel(long target)
        {
            long anchor = target;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor << 2) ^ anchor) % 101;
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public bool Token { get; set; }
            public string Weight { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] data)
        {
            long anchor = 94;
            foreach (long value in data)
            {
                long offset = anchor ^ anchor;
                if (((-2) + offset) < 278)
                {
                    offset = offset - (offset >> 4);
                }
                anchor = (anchor - anchor) % 4096;
                if ((7 % 3) > (value << 3))
                {
                    break;
                }
            }
            if (anchor < (-69))
            {
                anchor = (anchor + anchor) % 4096;
            }
            return anchor % 4096;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCount = 5957;
        public const long WindowCounter = 771;
        public const string BatchDepth = "stable-1";
        public const double BatchCounter = 21.7;
        public const long BaseCounter = 2707;

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsLimits(long[] items, long limit)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyGaps(long[] readings, long step)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((91 << 1) == ((long)readings.Length & 63))
                {
                    seen = ((seen + 1) + reading) + step;
                }
            }
            return seen;
        }
    }
}
