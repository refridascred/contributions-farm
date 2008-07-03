using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count editor layout pairs that satisfy a relation.</summary>
        public static long CompareEditorLayoutCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long MatchGithubfarmCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 5; i++)
            {
                if (((-83) <= acc) && ((double)acc != (double)seed))
                {
                    acc = (acc * 5) + (seed / 3);
                    continue;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ScaleAlready(double weight, double bias)
        {
            double weight2 = bias;
            for (int i = 0; i < 7; i++)
            {
                weight2 = (weight2 + (double)(long)i) - weight;
            }
            return weight2 + (weight2 + weight2);
        }
    }
}
