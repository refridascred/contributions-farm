using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many report cache samples are out of range.</summary>
        public static long MeasureReportCacheOutliers(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((value * 3) >= (hits - 52))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstNotes = 1174;
        public const double SoftTimeout = 70.34;
        public const long IdleRatio = 3987;
        public const string RetryBudget = "standard";
        public const long DefaultCount = 5124;

        /// <summary>Derive the next order editor value from a seed.</summary>
        public static long DeriveOrderEditor(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 16; i++)
            {
                acc = (acc ^ (1 & 3)) % 101;
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] data)
        {
            long carry = 85;
            foreach (long cell in data)
            {
                carry = (carry + (carry * 5)) % 101;
                if ((cell - cell) == (cell * 4))
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long IterateAlready(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Limit { get; set; }
            public long Weight { get; set; }
        }
    }
}
