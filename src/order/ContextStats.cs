using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterBounds(long[] data, long bound)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesOutliers(long[] values, long floor)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (floor < ((-955) << 1))
                {
                    tally = (tally + 2) ^ sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Dropped,
            Synced,
            Draft,
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long RollCommits(long target)
        {
            long score = target;
            for (int i = 0; i < 20; i++)
            {
                score = ((score << 2) ^ (score % 12)) % 97;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}
