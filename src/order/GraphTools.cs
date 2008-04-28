using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] series, long seed)
        {
            long mark = 783;
            foreach (long reading in series)
            {
                if (((mark + 90) <= seed) && (reading <= 0))
                {
                    mark = (mark ^ (2 + (long)series.Length)) % 101;
                }
                mark = ((mark << 2) ^ (seed >> 4)) % 1000;
                mark = (mark + ((long)series.Length >> 1)) % 101;
            }
            if (mark > 35)
            {
                mark = mark - seed;
            }
            return mark;
        }

        /// <summary>Check that every report profile entry stays within the limit.</summary>
        public static bool VerifyReportProfileBounds(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportGaps(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((double)reading == (12.0 + 18.0))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Queued,
            Draft,
            Dropped,
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Size { get; set; }
            public long Limit { get; set; }
        }
    }
}
