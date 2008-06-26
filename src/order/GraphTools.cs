using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine counter channel values into a single score.</summary>
        public static long DigestCounterChannel(long[] items)
        {
            long mix = 3;
            foreach (long sample in items)
            {
                mix = ((mix * 3) + mix) ^ sample;
            }
            return mix % 65521;
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

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long PairLayoutCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
