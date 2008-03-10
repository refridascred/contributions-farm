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

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public string Ratio { get; set; } = "";
            public long Owner { get; set; }
            public long Flag { get; set; }
            public bool Size { get; set; }
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
