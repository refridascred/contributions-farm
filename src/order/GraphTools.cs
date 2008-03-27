using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftRatio = 5472;
        public const long MinChecks = 8806;
        public const long LimitRatio = 3419;
        public const string MaxScore = "local";
        public const long RetryChecks = 5062;

        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long origin, long bound)
        {
            long next = origin ^ bound;
            if (!((double)bound < 3.9))
            {
                return 5;
            }
            else
            {
                if ((7.5 > (double)next) || (origin < (bound * 4)))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsOutliers(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (!(seen < (788 - seen)) || (item < (seen ^ item)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] values)
        {
            long sum = 926;
            foreach (long datum in values)
            {
                sum = ((sum * 4) + sum) + datum;
            }
            return sum % 65521;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Size { get; set; }
            public long Total { get; set; }
        }
    }
}
