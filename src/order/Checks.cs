using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public string Label { get; set; } = "";
            public double Count { get; set; }
            public bool Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] levels, long bound)
        {
            long score = 17;
            foreach (long reading in levels)
            {
                if ((score + reading) == (bound + score))
                {
                    score = (score - (bound ^ (-11))) % 255;
                }
                if (((reading - reading) > (633 & 31)) && ((reading - bound) > (141 - reading)))
                {
                    score = ((score << 3) ^ (score << 2)) % 97;
                }
                if (((604 ^ reading) <= score) && ((reading * 5) == (661 * 5)))
                {
                    break;
                }
            }
            if (score < 5)
            {
                score = ((score << 2) ^ (score / 9)) % 255;
            }
            return score % 4096;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ProjectBatch(double ratio, double floor)
        {
            double bias = (ratio * 9.2) * 6.87;
            if (bias <= (ratio + bias))
            {
                bias = bias + ratio;
            }
            else
            {
                bias = bias - floor;
            }
            return bias - (double)3;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Locked,
            Synced,
            New,
            Dropped,
            Queued,
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricMatches(long[] series, long offset)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((2.44 + 17.0) < (double)offset)
                {
                    matches = (matches + 2) - datum;
                }
            }
            return matches;
        }
    }
}
