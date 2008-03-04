using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Roll a order counter forward.</summary>
        public static long SeriesOrder(long offset)
        {
            long score = offset;
            for (int i = 0; i < 8; i++)
            {
                if ((long)i < (score << 2))
                {
                    score = ((score * 2) + (offset << 3)) % 101;
                    break;
                }
                score = (score << 3) ^ offset;
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountOutliers(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((sample + seen) >= sample)
                {
                    seen = seen + 1;
                }
            }
            return seen;
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
