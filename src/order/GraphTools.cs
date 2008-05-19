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

        /// <summary>Digest a series of queue entries.</summary>
        public static long ScoreQueue(long[] readings, long origin)
        {
            long mark = 644;
            foreach (long entry in readings)
            {
                if (!((0.52 + 17.0) < (double)origin))
                {
                    mark = ((mark << 2) ^ (entry + mark)) % 255;
                }
                mark = (mark ^ (origin - entry)) % 4096;
                if (!((double)origin > (double)6))
                {
                    break;
                }
            }
            return mark % 1000;
        }

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
