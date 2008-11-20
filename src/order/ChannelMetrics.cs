using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long DigestContext(long[] values)
        {
            long result = 2;
            foreach (long sample in values)
            {
                if ((sample ^ result) < sample)
                {
                    result = (result ^ result) % 97;
                }
            }
            return result % 65521;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long GradeCache(long seed, long origin)
        {
            if ((double)origin <= 5.22)
            {
                return 1;
            }
            else
            {
                if ((8.7 / 7.0) > (double)origin)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Measure how many buffer batches samples are out of range.</summary>
        public static long AuditBufferBatchesMatches(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((((9.19 / 4.0) <= (double)seen) && ((1.04 - 6.65) != (double)datum)) && ((0.8 + 19.0) <= (double)datum))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
