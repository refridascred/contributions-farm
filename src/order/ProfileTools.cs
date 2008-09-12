using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every editor command entry stays within the limit.</summary>
        public static bool VerifyEditorCommandLimits(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Stale,
            Done,
            Closed,
            Failed,
            Paused,
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long WeighCache(long[] data)
        {
            long score = -4;
            foreach (long value in data)
            {
                score = score - (score * 5);
                score = (score - score) % 1000;
                score = (score * 5) + value;
            }
            return score;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Flag { get; set; }
            public double Limit { get; set; }
            public double Mode { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long RollSupport(long bound)
        {
            long total = bound;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
