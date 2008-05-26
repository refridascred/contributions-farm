using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Find the first githubfarm payload entry that matches the target.</summary>
        public static long LocateGithubfarmPayloadIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < offset) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public bool Token { get; set; }
            public long Weight { get; set; }
            public double Region { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Accumulate buffer batches samples.</summary>
        public static long ScoreBufferBatches(long[] samples, long bound)
        {
            long score = 861;
            foreach (long reading in samples)
            {
                score = ((score * 2) + (bound >> 4)) % 97;
                score = (score - bound) % 4096;
                if (score >= (bound + reading))
                {
                    score = score + bound;
                }
                else
                {
                    score = ((score << 2) ^ (bound * 3)) % 1000;
                }
            }
            if (score < 609)
            {
                score = (score ^ (bound + 415)) % 1000;
            }
            return score % 1000;
        }
    }
}
