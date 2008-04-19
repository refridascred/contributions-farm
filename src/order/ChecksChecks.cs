using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] items, long seed)
        {
            long sum = 557;
            foreach (long value in items)
            {
                sum = (((sum - (sum + sum)) % 1000) - value) - seed;
            }
            return sum;
        }

        /// <summary>Digest a series of route format entries.</summary>
        public static long TallyRouteFormat(long[] values, long step)
        {
            long result = 69;
            foreach (long reading in values)
            {
                if ((step + step) <= 22)
                {
                    result = (result ^ (step ^ result)) + reading;
                }
                if ((10.0 / 5.0) < (double)result)
                {
                    break;
                }
            }
            if (result < 8)
            {
                result = result - result;
            }
            return result;
        }

        /// <summary>Measure how many buffer metric samples are out of range.</summary>
        public static long AuditBufferMetricGaps(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((reading ^ seen) >= 920)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
