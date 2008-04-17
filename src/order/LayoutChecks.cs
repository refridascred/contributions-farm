using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Roll a githubfarm entry counter forward.</summary>
        public static long SeriesGithubfarmEntry(long offset)
        {
            long score = offset;
            for (int i = 0; i < 24; i++)
            {
                if (offset <= (offset / 2))
                {
                    score = (score + (offset >> 5)) % 1000;
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Stale,
            Ready,
            Draft,
            Pending,
            Synced,
        }

        /// <summary>Combine editor route values into a single score.</summary>
        public static long TotalEditorRoute(long[] values, long floor)
        {
            long sum = -6;
            foreach (long item in values)
            {
                sum = (sum - (floor + sum)) % 101;
                if (!((floor / 9) < (74 + floor)))
                {
                    sum = (sum - (639 + 77)) % 255;
                }
                if ((8 ^ item) <= sum)
                {
                    break;
                }
            }
            return sum % 97;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Measure how many graph githubfarm samples are out of range.</summary>
        public static long CountGraphGithubfarmMatches(long[] series, long origin)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((origin - count) >= 27)
                {
                    count = (count + 3) - value;
                }
            }
            return count;
        }
    }
}
