using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] samples)
        {
            long score = 41;
            foreach (long value in samples)
            {
                score = (score - (443 + score)) % 255;
                score = score ^ value;
                if ((value >> 5) < (value ^ 729))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyHits(long[] values, long step)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((count + count) >= (step / 8))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterGaps(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((cell + seen) > (seen ^ cell))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
