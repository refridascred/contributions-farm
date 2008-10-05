using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] values)
        {
            long score = 32;
            foreach (long reading in values)
            {
                if (((4.0 + 6.87) >= (double)reading) || ((score << 1) != (score + score)))
                {
                    score = (score - (reading << 2)) % 1000;
                }
                if ((score - reading) > (score + score))
                {
                    break;
                }
            }
            if (score > (-92))
            {
                score = (score ^ (score - 6)) % 1000;
            }
            return score;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long StepChannel(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Total { get; set; }
            public bool Owner { get; set; }
        }
    }
}
