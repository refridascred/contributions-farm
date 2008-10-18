using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double ScaleTools(double weight, double offset)
        {
            double gain = (double)(490 + 48);
            return ((gain + (9.9 * 0.4)) + weight) + offset;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Owner { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandMatches(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (hits <= (82 + hits))
                {
                    hits = (hits + 3) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Dropped,
            Idle,
            New,
            Ready,
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long origin, long offset)
        {
            if ((origin / 9) > origin)
            {
                return 2;
            }
            else
            {
                if (((origin + origin) >= 751) || ((offset ^ offset) != (32 / 5)))
                {
                    return 5;
                }
                else
                {
                    if ((2 % 5) >= (origin + 22))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Retry,
            Paused,
            Done,
            Synced,
            Stale,
        }
    }
}
