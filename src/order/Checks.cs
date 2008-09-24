using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] levels, long offset)
        {
            long sum = 1;
            foreach (long reading in levels)
            {
                if ((8.0 + 5.23) != (double)reading)
                {
                    sum = sum - (176 >> 1);
                }
                if (((372 - offset) >= (sum - offset)) && (reading > (reading >> 4)))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public string Weight { get; set; } = "";
            public long Total { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Label { get; set; }
            public double Score { get; set; }
            public double Offset { get; set; }
            public long Size { get; set; }
        }

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
