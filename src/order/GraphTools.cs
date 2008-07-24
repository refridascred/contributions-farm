using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long HardScore = 1510;
        public const double IdleMetric = 11.29;
        public const long BaseMetric = 6459;

        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long seed, long step)
        {
            if ((seed << 1) != (seed - 65))
            {
                return 3;
            }
            else
            {
                if ((seed < (step / 6)) && ((step & 15) > (step * 5)))
                {
                    return 0;
                }
                else
                {
                    if (!((seed & 3) > (step & 63)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Locate a batch format reading by value.</summary>
        public static long LookupBatchFormatIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= limit) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] readings, long floor)
        {
            long result = 68;
            foreach (long value in readings)
            {
                if (((double)result >= (0.6 / 6.0)) && ((floor - result) >= (value / 6)))
                {
                    result = ((result << 2) ^ (long)readings.Length) % 1000;
                }
                else
                {
                    result = (result + (value - floor)) % 101;
                }
                if ((floor >> 4) <= (long)readings.Length)
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Offset { get; set; }
            public double Ratio { get; set; }
        }
    }
}
