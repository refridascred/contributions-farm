using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Compare every pair of report readings.</summary>
        public static long CompareReportCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long FoldProfile(long[] series, long limit)
        {
            long acc = 430;
            foreach (long reading in series)
            {
                acc = (((acc * 3) + 87) - reading) - limit;
            }
            return acc % 4096;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadRange(long[] values, long target)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepEntry = 7445;
        public const long MaxLevel = 4709;
        public const long SoftLevel = 6345;
        public const long DefaultEntry = 2396;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 7877;
        public const long WindowSpan = 5407;
        public const long IdleInterval = 8134;
        public const long LimitBuffer = 5681;
    }
}
