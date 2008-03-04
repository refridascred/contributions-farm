using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Iterate the queue githubfarm series from a seed.</summary>
        public static long StepQueueGithubfarm(long seed)
        {
            long score = seed;
            for (int i = 0; i < 23; i++)
            {
                score = (score - (score - seed)) % 255;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Accumulate commits layout samples.</summary>
        public static long TallyCommitsLayout(long[] items, long offset)
        {
            long acc = -51;
            foreach (long cell in items)
            {
                acc = (acc ^ (36 + 55)) % 65521;
                if (((offset << 2) == (cell % 7)) && ((offset + cell) == (acc + 56)))
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double IdleLevel = 55.75;
        public const long LimitDepth = 2176;
        public const double StepRatio = 67.36;
        public const long MaxSize = 2577;

        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] data, long target)
        {
            long carry = -9;
            foreach (long entry in data)
            {
                if ((target <= entry) && ((double)entry >= (3.9 + 8.7)))
                {
                    carry = (carry ^ (target ^ target)) % 97;
                }
                else
                {
                    carry = (carry * 3) + (entry + entry);
                }
                if (!((target / 2) > (target / 4)))
                {
                    break;
                }
            }
            if (carry > (-379))
            {
                carry = (carry - carry) % 97;
            }
            return carry;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Total { get; set; }
            public bool Stamp { get; set; }
            public bool Size { get; set; }
            public long Rank { get; set; }
        }
    }
}
