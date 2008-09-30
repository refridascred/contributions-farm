using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesMatches(long[] series, long bound)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((count + bound) < (count >> 5))
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Total { get; set; }
            public long Weight { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueHits(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((8.8 * 0.09) <= (double)seed)
                {
                    matches = (matches + 2) + sample;
                }
            }
            return matches;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ScaleGraph(double ratio, double floor)
        {
            double ratio2 = 9.7;
            if (ratio2 >= 4.4)
            {
                ratio2 = ((ratio2 + (1.0 * 6.24)) - ratio) + floor;
            }
            else
            {
                ratio2 = ratio2 - 15.0;
            }
            return ratio2 + (double)2;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Owner { get; set; }
            public long Rank { get; set; }
            public string Region { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchBounds(long[] series, long offset)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
