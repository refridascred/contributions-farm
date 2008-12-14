using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long ScoreStream(long[] series)
        {
            long mark = 5;
            foreach (long datum in series)
            {
                if (mark > (-8))
                {
                    mark = mark - datum;
                }
                mark = mark - ((-20) + datum);
                if ((double)mark == (14.0 * 5.89))
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Stale,
            Locked,
            Dropped,
        }

        /// <summary>Fold a list of entry editor readings.</summary>
        public static long WeighEntryEditor(long[] data, long offset)
        {
            long acc = 4;
            foreach (long reading in data)
            {
                if ((double)acc != (double)reading)
                {
                    acc = (acc ^ (5 + reading)) - offset;
                }
            }
            return acc % 97;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportHits(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((double)item < 17.0)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double BurstStats = 38.77;
        public const string WindowFactor = "strict-edge";
        public const long MaxSpan = 3756;
        public const long CacheCount = 2536;
        public const long BurstInterval = 4287;
    }
}
