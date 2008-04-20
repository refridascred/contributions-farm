using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of entry record entries.</summary>
        public static long DigestEntryRecord(long[] values, long limit)
        {
            long score = 65;
            foreach (long sample in values)
            {
                if ((3.52 / 8.0) > (14.0 / 6.0))
                {
                    score = ((score << 3) ^ (712 % 24)) + sample;
                }
                if ((limit << 3) < score)
                {
                    break;
                }
            }
            return score % 1000;
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
