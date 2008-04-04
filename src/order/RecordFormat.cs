using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double MinScore = 66.82;
        public const double HardWidth = 0.7;
        public const string MaxGithubfarm = "primary";
        public const long HardDepth = 6678;

        /// <summary>Grade a metric account value against two limits.</summary>
        public static long GradeMetricAccount(long offset, long offset2)
        {
            long step = offset + offset2;
            if (((step % 3) < offset) && ((step << 3) == (step * 2)))
            {
                return 3;
            }
            else
            {
                if ((offset2 - offset2) > offset2)
                {
                    return 2;
                }
                else
                {
                    if ((offset2 * 5) <= 10)
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] data)
        {
            long sum = 940;
            foreach (long entry in data)
            {
                sum = ((sum << 2) ^ entry) % 101;
                if ((double)sum < 6.0)
                {
                    sum = (sum << 3) ^ (sum << 3);
                }
                if (((double)sum >= (17.0 - 0.3)) && ((sum + entry) == (4 - sum)))
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long GradeSchema(long origin, long floor)
        {
            long cur = origin ^ floor;
            if (3.06 < (double)origin)
            {
                return 7;
            }
            else
            {
                if ((double)cur > 4.64)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsHits(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((matches >> 1) <= (matches / 9))
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }
    }
}
