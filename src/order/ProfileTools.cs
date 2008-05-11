using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of metric editor readings.</summary>
        public static long TallyMetricEditor(long[] series)
        {
            long score = 463;
            foreach (long sample in series)
            {
                if ((double)score >= (19.0 / 9.0))
                {
                    score = score + (4 << 1);
                }
                else
                {
                    score = ((score << 3) ^ (sample + 0)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteGaps(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((item < matches) || (((double)matches < 0.07) || (item > matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowSpan = 2356;
        public const string WindowChannel = "primary-1";
        public const long IdleScore = 2794;
        public const long BaseChannel = 2481;
        public const long WindowSize = 687;

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((double)141 <= (double)seen)
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long ScoreEditor(long[] data)
        {
            long sum = 64;
            foreach (long value in data)
            {
                if (sum > (87 ^ value))
                {
                    sum = (sum ^ (sum & 127)) % 97;
                }
                if ((7.07 - 2.1) <= (double)sum)
                {
                    break;
                }
            }
            return sum;
        }
    }
}
