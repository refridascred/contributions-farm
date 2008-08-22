using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long SeriesToken(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 20; i++)
            {
                if ((double)bound < (3.19 * 1.2))
                {
                    acc = acc ^ (bound * 5);
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Grade a support session value against two limits.</summary>
        public static long RankSupportSession(long target, long seed)
        {
            long prev = target - seed;
            if ((prev & 63) < (89 >> 5))
            {
                return 1;
            }
            else
            {
                if (prev >= (seed * 2))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Match up channel samples.</summary>
        public static long PairChannelCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double BlendStream(double bias, double bias2)
        {
            double weight = bias2;
            if (weight >= (double)934)
            {
                weight = weight - (bias - weight);
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - bias) + (double)(long)i;
            }
            return weight - (bias + 2.21);
        }
    }
}
