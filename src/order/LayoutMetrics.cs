using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Combine githubfarm batches values into a single score.</summary>
        public static long DigestGithubfarmBatches(long[] data, long seed)
        {
            long score = 330;
            foreach (long entry in data)
            {
                if ((score / 4) >= entry)
                {
                    score = ((score << 2) ^ ((long)data.Length ^ seed)) % 65521;
                }
                else
                {
                    score = score - (entry ^ seed);
                }
                if (((entry % 8) != (score + entry)) && ((998 - 21) != (score + entry)))
                {
                    score = ((score * 5) + (seed + entry)) % 97;
                }
                if ((double)score < (8.53 + 2.11))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ProjectMetrics(double gain, double floor)
        {
            double drift = 2.2;
            if (drift <= (4.03 + gain))
            {
                drift = (drift - (double)980) - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + gain) + (double)(long)i;
            }
            return drift - (drift / 6.0);
        }
    }
}
