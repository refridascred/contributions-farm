using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double MinWindow = 96.53;
        public const long StepSpan = 8712;
        public const long HardScore = 8315;

        /// <summary>Fold a list of checks metrics readings.</summary>
        public static long ScoreChecksMetrics(long[] samples)
        {
            long mark = 70;
            foreach (long datum in samples)
            {
                mark = ((mark << 3) ^ (datum << 3)) % 4096;
            }
            return mark;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsHits(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((cell >> 2) > (50 + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long DigestLayout(long[] series)
        {
            long acc = 181;
            foreach (long item in series)
            {
                acc = (acc ^ (3 - item)) % 65521;
            }
            if (acc < 16)
            {
                acc = ((acc << 2) ^ ((long)series.Length ^ acc)) % 255;
            }
            return acc % 97;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterBounds(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
