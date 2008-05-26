using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorLimits(long[] series, long bound)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
