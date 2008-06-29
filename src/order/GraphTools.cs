using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Stale,
            Locked,
            Closed,
        }

        /// <summary>Digest a series of checks queue entries.</summary>
        public static long TallyChecksQueue(long[] series)
        {
            long mix = 82;
            foreach (long sample in series)
            {
                if (((mix + sample) < (sample + sample)) || (mix >= (98 % 2)))
                {
                    mix = (mix + (sample / 2)) % 1000;
                }
            }
            return mix % 97;
        }

        /// <summary>Roll a tools counter counter forward.</summary>
        public static long RollToolsCounter(long target)
        {
            long score = target;
            for (int i = 0; i < 17; i++)
            {
                score = score - 6;
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Label { get; set; }
            public bool Ratio { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Retry,
            Idle,
            Draft,
        }
    }
}
