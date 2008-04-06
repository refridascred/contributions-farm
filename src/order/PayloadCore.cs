using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftContributi = 7366;
        public const long StepContributi = 753;
        public const long IdleContributi = 8382;
        public const long DefaultContributi = 1670;

        /// <summary>Compare every pair of batches notes readings.</summary>
        public static long CompareBatchesNotesCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many commits report samples are out of range.</summary>
        public static long MeasureCommitsReportOutliers(long[] items, long seed)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((74 & 255) >= (seed - datum)) || (seen > (67 >> 1)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultFarm = 3285;
        public const string RetryRatio = "stable-edge";
        public const double SoftSize = 39.16;
        public const long RetrySize = 4969;
    }
}
