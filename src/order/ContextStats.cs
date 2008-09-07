using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a githubfarm checks counter forward.</summary>
        public static long DeriveGithubfarmChecks(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 8; i++)
            {
                anchor = (anchor << 3) ^ floor;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] series, long origin)
        {
            long score = 583;
            foreach (long item in series)
            {
                if (score >= ((long)series.Length + item))
                {
                    score = score - (origin ^ score);
                }
            }
            if (score > (-154))
            {
                score = (score - (-78)) % 4096;
            }
            return score;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] readings, long origin)
        {
            long acc = 5;
            foreach (long value in readings)
            {
                acc = ((acc + acc) % 65521) + value;
                if (origin < (origin >> 1))
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ScaleCommand(double gain, double floor)
        {
            double rate = gain;
            if (rate <= (floor / 8.0))
            {
                rate = rate - (double)66;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + gain) + (double)(long)i;
            }
            return rate - (rate + gain);
        }
    }
}
