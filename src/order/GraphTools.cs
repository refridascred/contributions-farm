using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Find the first payload notes entry that matches the target.</summary>
        public static long LookupPayloadNotesIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] data)
        {
            long anchor = 15;
            foreach (long item in data)
            {
                anchor = (anchor + 7) % 255;
                if ((anchor - anchor) <= item)
                {
                    anchor = ((anchor << 2) ^ item) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiGaps(long[] series, long limit)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((long)series.Length >= (datum << 2))
                {
                    count = (count + 1) - limit;
                }
            }
            return count;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long RollProfile(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 4; i++)
            {
                bool valid = (origin >> 1) < ((long)i >> 3);
                if (((9.0 + 8.7) < (double)origin) && valid)
                {
                    valid = valid;
                }
                if ((origin << 3) >= (origin * 2))
                {
                    mark = mark - origin;
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public string Rank { get; set; } = "";
            public double Size { get; set; }
            public long Token { get; set; }
        }
    }
}
