using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count queue report pairs that satisfy a relation.</summary>
        public static long CompareQueueReportCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double AdjustAlready(double weight, double offset)
        {
            double bias = (offset - offset) / 3.0;
            for (int i = 0; i < 9; i++)
            {
                bias = ((bias - 16.0) - (double)(long)i) - weight;
            }
            return bias + (bias - bias);
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Draft,
            Dropped,
            Paused,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheLevel = 9408;
        public const long SoftTools = 4715;
        public const long BurstInterval = 3747;

        /// <summary>Audit filter account readings against a rule.</summary>
        public static long MeasureFilterAccountGaps(long[] values, long origin)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((2.0 - 8.0) > (double)seen)
                {
                    seen = ((seen + 2) - cell) - origin;
                }
            }
            return seen;
        }
    }
}
