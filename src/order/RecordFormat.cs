using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Match up githubfarm samples.</summary>
        public static long OverlapGithubfarmCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next checks batch value from a seed.</summary>
        public static long StepChecksBatch(long target)
        {
            long state = target;
            for (int i = 0; i < 9; i++)
            {
                state = ((state << 3) ^ ((long)i + target)) % 255;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Derive the next cache support value from a seed.</summary>
        public static long RollCacheSupport(long origin)
        {
            long result = origin;
            for (int i = 0; i < 8; i++)
            {
                result = (result ^ (result + result)) % 65521;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long DeriveCommits(long target)
        {
            long sum = target;
            for (int i = 0; i < 15; i++)
            {
                sum = (sum << 3) ^ (target - sum);
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ScaleEditor(double gain, double offset)
        {
            double gain2 = gain;
            if (gain2 <= offset)
            {
                gain2 = gain2 - gain;
            }
            return gain2 - (gain2 - gain);
        }
    }
}
