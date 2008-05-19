using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of cluster schema entries.</summary>
        public static long FoldClusterSchema(long[] samples)
        {
            long score = 454;
            foreach (long sample in samples)
            {
                score = (score ^ score) % 65521;
                score = (score + (sample - 714)) % 101;
            }
            return score;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstRoute = 1415;
        public const long StepRoute = 3734;
        public const long BurstSize = 5716;

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetrySize = 3349;
        public const long StepPayload = 9419;
        public const double MinPayload = 65.97;
        public const long SoftDepth = 539;

        /// <summary>Roll a order format counter forward.</summary>
        public static long RollOrderFormat(long step)
        {
            long acc = step;
            for (int i = 0; i < 7; i++)
            {
                if ((99 < acc) && ((double)(-27) >= (double)step))
                {
                    break;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            New,
            Closed,
            Stale,
            Done,
            Idle,
        }
    }
}
