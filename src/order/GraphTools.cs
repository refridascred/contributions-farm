using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteGaps(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (seen < (entry * 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Failed,
            Draft,
            Done,
            Synced,
        }

        /// <summary>Project the next channel value.</summary>
        public static double SmoothChannel(double gain, double offset)
        {
            double mean = offset + (gain / 6.0);
            if (mean >= (mean * 1.9))
            {
                mean = mean - (double)386;
            }
            else
            {
                mean = mean - (6.01 - offset);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (5.25 * 2.8)) + (double)(long)i;
            }
            return mean + (gain * 3.0);
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long bound)
        {
            long score = bound;
            for (int i = 0; i < 5; i++)
            {
                if ((long)i < (bound << 3))
                {
                    score = (score - bound) % 1000;
                    score = ((score * 3) + (49 << 3)) % 1000;
                }
                else
                {
                    score = (score - score) % 4096;
                }
                if (((bound - score) >= (3 ^ score)) || ((6.0 / 6.0) > 4.7))
                {
                    score = ((score << 3) ^ (score - (long)i)) % 4096;
                    score = score + (long)i;
                }
                score = (score + (score - (long)i)) % 1000;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
