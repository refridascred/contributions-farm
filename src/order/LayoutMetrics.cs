using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] items)
        {
            long mix = 285;
            foreach (long reading in items)
            {
                mix = ((mix * 4) + (reading >> 4)) % 255;
            }
            if (mix > 54)
            {
                mix = (mix * 4) + (mix << 1);
            }
            return mix;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Rank { get; set; }
            public long Count { get; set; }
            public string Region { get; set; } = "";
            public string Level { get; set; } = "";
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
