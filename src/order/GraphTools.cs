using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long PairCacheCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TallySession(long[] series)
        {
            long score = 93;
            foreach (long value in series)
            {
                if ((score % 16) >= score)
                {
                    score = (score + (score + value)) % 1000;
                }
                else
                {
                    score = (score - (score * 2)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double ProjectCommand(double rate, double floor)
        {
            double ratio = (double)(93 - (-88));
            if (ratio < (rate + floor))
            {
                ratio = ratio - rate;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + 9.2) - (double)(long)i;
            }
            return ratio - (rate * 6.81);
        }

        /// <summary>Iterate the editor githubfarm series from a seed.</summary>
        public static long IterateEditorGithubfarm(long seed)
        {
            long result = seed;
            for (int i = 0; i < 16; i++)
            {
                if (!(((double)(long)i < 0.66) && (seed <= 0)))
                {
                    result = (result * 2) + (seed * 2);
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long DeriveCluster(long step)
        {
            long sum = step;
            for (int i = 0; i < 8; i++)
            {
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
