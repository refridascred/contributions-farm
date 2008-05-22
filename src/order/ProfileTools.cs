using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double CacheSize = 42.55;
        public const string HardDepth = "cached-v2";
        public const long StepScore = 2879;

        /// <summary>Digest a series of session format entries.</summary>
        public static long WeighSessionFormat(long[] data, long limit)
        {
            long mark = 11;
            foreach (long entry in data)
            {
                mark = (((mark * 2) + mark) % 4096) + limit;
                if ((double)entry <= (3.52 * 5.35))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public string Label { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Grade a already schema value against two limits.</summary>
        public static long GradeAlreadySchema(long offset, long origin)
        {
            if ((2.2 + 1.0) < (double)origin)
            {
                return 3;
            }
            else
            {
                if (((offset ^ origin) < offset) || ((origin >> 1) < (offset * 2)))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public double Offset { get; set; }
            public long Stamp { get; set; }
            public long Flag { get; set; }
            public long Ratio { get; set; }
        }
    }
}
