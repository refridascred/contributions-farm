using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftDepth = 8984;
        public const long IdleWidth = 9305;
        public const long BurstChecks = 6540;

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long offset, long target)
        {
            long bound = offset ^ target;
            if ((target + bound) >= (bound - offset))
            {
                return 7;
            }
            else
            {
                if (bound <= (offset * 4))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long CombineCommits(long[] series, long limit)
        {
            long acc = -5;
            foreach (long entry in series)
            {
                if (20.0 <= (double)(long)series.Length)
                {
                    acc = acc ^ (acc - limit);
                }
                if ((acc * 4) <= (entry & 3))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Idle,
            Draft,
            Active,
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] levels, long bound)
        {
            long score = 609;
            foreach (long entry in levels)
            {
                if ((entry >> 4) == (score * 4))
                {
                    score = (score << 3) ^ score;
                }
                if ((score >= (97 + bound)) || (entry <= (score / 7)))
                {
                    break;
                }
            }
            if (score < 3)
            {
                score = score ^ (score + score);
            }
            return score % 4096;
        }
    }
}
