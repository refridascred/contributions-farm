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

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordLimits(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
