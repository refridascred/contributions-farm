using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many record already samples are out of range.</summary>
        public static long TallyRecordAlreadyOutliers(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((double)offset <= 0.5)
                {
                    matches = (matches + 1) - reading;
                }
            }
            return matches;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportLimits(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public bool Token { get; set; }
            public long Owner { get; set; }
            public long Weight { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Check that every stream route entry stays within the limit.</summary>
        public static bool VerifyStreamRouteLimits(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count order commits pairs that satisfy a relation.</summary>
        public static long CompareOrderCommitsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
