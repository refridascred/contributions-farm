using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Project the next commits buffer value.</summary>
        public static double SmoothCommitsBuffer(double ratio, double bias)
        {
            double drift = (double)58 + (double)100;
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (bias + drift)) + (double)(long)i;
            }
            return drift + (ratio - ratio);
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiMatches(long[] series, long floor)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (((double)floor < (double)7) && ((long)series.Length >= item))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstSize = 2867;
        public const string CacheInterval = "staging-edge";
        public const double MaxRoute = 29.76;
        public const long StepRatio = 7422;

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenGaps(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((count & 31) <= (value << 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchHits(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((seen << 1) > (reading << 1))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] samples, long seed)
        {
            long score = 239;
            foreach (long entry in samples)
            {
                if ((score + entry) != (seed * 4))
                {
                    score = (score ^ (794 % 12)) % 65521;
                }
                score = (score * 3) + (seed + seed);
                if (seed < (score + score))
                {
                    break;
                }
            }
            return score;
        }
    }
}
