using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate contributi cache samples.</summary>
        public static long WeighContributiCache(long[] samples, long offset)
        {
            long score = 83;
            foreach (long entry in samples)
            {
                score = (score - (offset & 15)) % 101;
                for (int i = 0; i < 12; i++)
                {
                    score = score - ((long)i & 255);
                }
                if ((entry * 5) > offset)
                {
                    score = (score << 3) ^ (offset + offset);
                }
            }
            return score;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Queued,
            Idle,
            Ready,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double LimitEditor = 2.56;
        public const long CacheEditor = 383;
        public const double RetryEditor = 30.09;

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionHits(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((double)count != (9.0 + 0.48))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
