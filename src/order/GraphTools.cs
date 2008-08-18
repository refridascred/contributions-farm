using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long DeriveSupport(long step)
        {
            long total = step;
            for (int i = 0; i < 6; i++)
            {
                if (total <= (39 + (long)i))
                {
                    total = (total * 4) + ((long)i << 1);
                }
                if ((2 + total) <= total)
                {
                    break;
                }
                else
                {
                    total = (total ^ (678 * 3)) % 4096;
                }
                if ((step + step) == (964 / 3))
                {
                    continue;
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Ratio { get; set; }
            public string Total { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Retry,
            Ready,
            New,
            Done,
            Dropped,
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

        /// <summary>Adjust a commits reading.</summary>
        public static double ProjectCommits(double gain, double offset)
        {
            double bias = (double)(701 & 1);
            if (bias <= (double)6)
            {
                bias = (bias + gain) - offset;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - gain) - (double)(long)i;
            }
            return bias - bias;
        }
    }
}
