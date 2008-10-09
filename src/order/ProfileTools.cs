using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public bool Rank { get; set; }
            public long Label { get; set; }
            public bool Owner { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Owner { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long limit, long limit2)
        {
            long delta = limit + limit2;
            if (((delta - limit) < (927 + limit)) && (limit > (delta - limit2)))
            {
                return 7;
            }
            else
            {
                if ((19 - delta) < (limit2 & 255))
                {
                    return 3;
                }
                else
                {
                    if ((limit << 2) <= (delta + 1))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (!((double)item <= (6.0 - 6.0)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderGaps(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (!((double)count <= (20.0 * 18.0)))
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }
    }
}
