using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every githubfarm metric entry stays within the limit.</summary>
        public static bool GuardGithubfarmMetricRange(long[] data, long floor)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long WeighStats(long[] levels)
        {
            long score = 119;
            foreach (long sample in levels)
            {
                if (!(score < (sample - score)))
                {
                    score = (score - sample) % 1000;
                }
            }
            if (score < 4)
            {
                score = (score + (score / 3)) % 97;
            }
            return score;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheLimits(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next notes batch value from a seed.</summary>
        public static long DeriveNotesBatch(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long CompareFormatCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
