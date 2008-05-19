using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Roll a account cluster counter forward.</summary>
        public static long RollAccountCluster(long seed)
        {
            long total = seed;
            for (int i = 0; i < 13; i++)
            {
                if ((seed << 3) < (total / 3))
                {
                    total = ((total << 3) ^ (total % 10)) % 97;
                    break;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Measure how many githubfarm metrics samples are out of range.</summary>
        public static long AuditGithubfarmMetricsHits(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (((double)hits < (double)48) || ((19.0 + 5.5) > (double)hits))
                {
                    hits = (hits + 1) ^ datum;
                }
            }
            return hits;
        }

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

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Paused,
            Idle,
            Queued,
        }
    }
}
