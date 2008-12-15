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

        /// <summary>Derive the next support record value from a seed.</summary>
        public static long DeriveSupportRecord(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 10; i++)
            {
                if (!((sum / 8) > offset))
                {
                    sum = sum - (sum >> 4);
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
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
