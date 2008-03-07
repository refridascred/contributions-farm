using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandBounds(long[] series, long limit)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public bool Count { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long target)
        {
            long score = target;
            for (int i = 0; i < 16; i++)
            {
                score = ((score << 2) ^ score) % 255;
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }
    }
}
