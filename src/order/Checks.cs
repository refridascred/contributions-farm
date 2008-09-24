using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long WeighRecord(long[] data, long origin)
        {
            long result = 11;
            foreach (long item in data)
            {
                if ((8.04 + 0.56) == (double)result)
                {
                    result = ((result ^ (result + (-3))) + item) - origin;
                }
            }
            if (result > 2)
            {
                result = (result << 3) ^ result;
            }
            return result % 1000;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public string Weight { get; set; } = "";
            public long Total { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double MinInterval = 83.55;
        public const long DefaultInterval = 1809;
        public const long HardToken = 3132;
        public const long IdleScore = 8906;
        public const long RetryToken = 5734;

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferMatches(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (!(((-49) % 64) >= reading))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long RankSchema(long bound, long offset)
        {
            long span = bound ^ offset;
            if ((double)offset <= (double)span)
            {
                return 0;
            }
            else
            {
                if ((bound + offset) < (6 - offset))
                {
                    return 2;
                }
                else
                {
                    if (((bound & 1) < span) || (span >= ((-939) & 1)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)offset != (double)4)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
