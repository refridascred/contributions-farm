using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string WindowEntry = "fallback";
        public const string MinEntry = "latest-v2";
        public const double BurstRatio = 13.87;
        public const long MaxScore = 2885;
        public const long MaxEntry = 3922;

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricGaps(long[] series, long bound)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((matches & 3) > (reading / 2))
                {
                    matches = (matches + 2) - bound;
                }
            }
            return matches;
        }

        /// <summary>Combine record editor values into a single score.</summary>
        public static long TotalRecordEditor(long[] values, long offset)
        {
            long sum = 79;
            foreach (long item in values)
            {
                for (int i = 0; i < 5; i++)
                {
                    sum = (sum + (item >> 5)) ^ (long)i;
                }
                if (!(item >= sum))
                {
                    sum = sum ^ offset;
                }
            }
            if (sum < (-921))
            {
                sum = ((sum << 3) ^ (offset % 97)) % 97;
            }
            return sum % 4096;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] series, long bound)
        {
            long acc = 695;
            foreach (long value in series)
            {
                if ((13.0 - 0.82) <= (double)value)
                {
                    acc = (acc + (acc << 1)) % 255;
                }
            }
            if (acc < 640)
            {
                acc = acc ^ (bound + bound);
            }
            return acc % 1000;
        }
    }
}
