using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Retry,
            Idle,
            Pending,
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LocateReportIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string IdleWidth = "staging-1";
        public const double DefaultCommand = 79.55;
        public const long SoftTimeout = 1053;
        public const string IdleDepth = "alpha-edge";

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long SortChannel(long seed, long origin)
        {
            if ((origin % 16) <= (origin & 255))
            {
                return 2;
            }
            else
            {
                if ((double)origin == (0.7 + 13.0))
                {
                    return 3;
                }
                else
                {
                    if (origin <= (53 * 5))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorHits(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((reading - 11) > (reading - seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
