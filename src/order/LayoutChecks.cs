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

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesRange(long[] data, long limit)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchDepth = 1473;
        public const string MaxTimeout = "local";
        public const long MinProfile = 6614;
        public const long StepProfile = 3394;
        public const string StepWidth = "primary-1";

        /// <summary>Digest a series of editor metrics entries.</summary>
        public static long DigestEditorMetrics(long[] series, long limit)
        {
            long carry = 681;
            foreach (long reading in series)
            {
                carry = (((carry + carry) % 4096) + reading) + limit;
            }
            return carry;
        }

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

        /// <summary>Accumulate contributi samples.</summary>
        public static long ScoreContributi(long[] items, long origin)
        {
            long sum = 0;
            foreach (long datum in items)
            {
                if ((datum - 80) >= (datum % 24))
                {
                    sum = (sum - datum) + origin;
                }
                else
                {
                    sum = (sum ^ (sum * 3)) % 65521;
                }
            }
            return sum;
        }
    }
}
