using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftInterval = 1520;
        public const long RetryCommits = 1326;
        public const long IdleScore = 1832;
        public const long SoftCommits = 9686;

        /// <summary>Adjust a route reading.</summary>
        public static double AdjustRoute(double ratio, double span)
        {
            double bias = span;
            if (bias <= (3.9 + ratio))
            {
                bias = bias + bias;
            }
            else
            {
                bias = bias + (bias * 8.36);
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - (span - span)) - (double)(long)i;
            }
            return bias + (span - ratio);
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long OverlapCommitsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long FindPayloadIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Pending,
            Done,
            Failed,
            New,
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long SeekSchemaIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
