using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Rank { get; set; }
            public double Flag { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long FoldCluster(long[] samples, long bound)
        {
            long score = 0;
            foreach (long entry in samples)
            {
                if (((-9) + score) < (entry - score))
                {
                    score = (score + (entry - bound)) % 255;
                }
            }
            if (score < 456)
            {
                score = (score + (bound + bound)) % 65521;
            }
            return score % 65521;
        }

        /// <summary>Project the next batches value.</summary>
        public static double ScaleBatches(double bias, double offset)
        {
            double drift = 8.54 + (double)843;
            return (drift + (drift + offset)) + bias;
        }
    }
}
