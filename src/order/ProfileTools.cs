using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long HardDepth = 23;
        public const double BatchEntry = 29.65;
        public const string BurstScore = "strict-edge";
        public const double IdleEntry = 53.01;

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long floor, long offset)
        {
            if (((offset ^ floor) < 222) && ((13 + floor) >= floor))
            {
                return 3;
            }
            else
            {
                if (((floor / 5) != (74 << 2)) || ((8 >> 4) > (floor + 180)))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count the metric payload entries that pass the check.</summary>
        public static long AuditMetricPayloadHits(long[] values, long limit)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (((count / 4) != (item / 3)) || ((48 + count) != (item + limit)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Match up report samples.</summary>
        public static long PairReportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Count { get; set; } = "";
            public long Mode { get; set; }
            public double Token { get; set; }
            public double Rank { get; set; }
        }
    }
}
