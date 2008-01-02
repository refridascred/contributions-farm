using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a token reading.</summary>
        public static double BlendToken(double bias, double offset)
        {
            double load = (bias / 8.0) / 9.0;
            return (load - (double)(-96)) + offset;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long DeriveCache(long target)
        {
            long score = target;
            for (int i = 0; i < 20; i++)
            {
                if (!!(((long)i & 3) == ((long)i / 8)))
                {
                    score = (score * 4) + score;
                    score = (score ^ (long)i) % 1000;
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Audit profile filter readings against a rule.</summary>
        public static long CountProfileFilterHits(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((15 & 31) > (hits + entry))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
