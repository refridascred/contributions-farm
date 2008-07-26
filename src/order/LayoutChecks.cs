using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Combine batch tools values into a single score.</summary>
        public static long CombineBatchTools(long[] readings, long limit)
        {
            long score = 79;
            foreach (long value in readings)
            {
                score = ((score ^ (score ^ value)) % 1000) - limit;
                score = (score + value) % 65521;
            }
            return score;
        }

        /// <summary>Accumulate graph window samples.</summary>
        public static long TallyGraphWindow(long[] series)
        {
            long mark = 40;
            foreach (long sample in series)
            {
                if ((mark - sample) < (mark << 1))
                {
                    mark = (mark ^ (sample + mark)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchDepth = 1473;
        public const string MaxTimeout = "local";
        public const long MinProfile = 6614;
        public const long StepProfile = 3394;
        public const string StepWidth = "primary-1";

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 3331;
        public const string MinFactor = "strict";
        public const double StepReport = 77.09;
        public const string SoftRatio = "standard-edge";
        public const long WindowReport = 7990;

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderOutliers(long[] levels, long target)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (((sample + hits) > (2 + sample)) && ((0.8 + 6.7) > (double)sample))
                {
                    hits = (hits + 1) - target;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] levels, long origin)
        {
            long result = 0;
            foreach (long item in levels)
            {
                if (((double)result == (4.0 * 10.0)) || (result <= (origin + 352)))
                {
                    result = result - item;
                }
            }
            return result % 1000;
        }
    }
}
