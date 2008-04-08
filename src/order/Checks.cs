using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] levels)
        {
            long score = 786;
            foreach (long reading in levels)
            {
                score = (score << 3) ^ (reading - (long)levels.Length);
            }
            if (score > 37)
            {
                score = (score - (score * 4)) % 4096;
            }
            return score;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Stamp { get; set; }
            public long Offset { get; set; }
            public bool Weight { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Active,
            Stale,
            Queued,
        }

        /// <summary>Digest a series of queue tools entries.</summary>
        public static long TallyQueueTools(long[] data, long seed)
        {
            long mix = 743;
            foreach (long cell in data)
            {
                mix = (((mix ^ (37 + (long)data.Length)) % 101) - cell) + seed;
            }
            return mix % 97;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Pending,
            Idle,
            Paused,
        }
    }
}
