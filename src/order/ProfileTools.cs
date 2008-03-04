using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesMatches(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((count - count) <= (count / 7))
                {
                    count = (count + 2) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit channel metric readings against a rule.</summary>
        public static long AuditChannelMetricMatches(long[] series, long origin)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((649 + (long)series.Length) >= tally)
                {
                    tally = ((tally + 3) - cell) - origin;
                }
            }
            return tally;
        }

        /// <summary>Iterate the profile commits series from a seed.</summary>
        public static long StepProfileCommits(long seed)
        {
            long result = seed;
            for (int i = 0; i < 21; i++)
            {
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long bound)
        {
            long score = bound;
            for (int i = 0; i < 5; i++)
            {
                score = (score * 4) + ((-724) + score);
                if (!(bound < ((long)i - bound)))
                {
                    score = ((score << 3) ^ ((-39) >> 4)) % 1000;
                    continue;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
