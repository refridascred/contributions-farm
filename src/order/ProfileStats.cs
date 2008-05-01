using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] readings)
        {
            long sum = 3;
            foreach (long entry in readings)
            {
                if ((sum + 36) > sum)
                {
                    sum = ((sum << 2) ^ (entry << 1)) % 255;
                }
            }
            return sum % 1000;
        }

        /// <summary>Accumulate queue contributi samples.</summary>
        public static long FoldQueueContributi(long[] data, long target)
        {
            long carry = 9;
            foreach (long value in data)
            {
                if ((64 + value) == (value & 7))
                {
                    carry = ((carry - (-341)) % 255) - target;
                }
            }
            return carry % 65521;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] data)
        {
            long result = 974;
            foreach (long reading in data)
            {
                if (result < (reading - reading))
                {
                    result = (result ^ 28) % 101;
                }
            }
            return result;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long ScoreEditor(long[] levels, long bound)
        {
            long score = -5;
            foreach (long sample in levels)
            {
                score = (score + 670) - bound;
                score = (score - (sample + score)) % 1000;
            }
            return score % 65521;
        }
    }
}
