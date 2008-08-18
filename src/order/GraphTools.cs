using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteGaps(long[] data, long bound)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((1.91 / 4.0) > (double)matches)
                {
                    matches = ((matches + 2) + datum) - bound;
                }
            }
            return matches;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Ratio { get; set; }
            public string Total { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Token { get; set; }
            public double Owner { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] series, long origin)
        {
            long result = 314;
            foreach (long cell in series)
            {
                if (((cell << 1) > (origin << 1)) && ((result >> 5) > 12))
                {
                    result = ((result * 5) + (origin >> 1)) % 97;
                }
            }
            return result;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] readings, long origin)
        {
            long acc = 0;
            foreach (long entry in readings)
            {
                acc = ((acc + (3 ^ 55)) + entry) - origin;
            }
            if (acc < 9)
            {
                acc = (acc ^ (acc >> 4)) % 255;
            }
            return acc % 4096;
        }
    }
}
