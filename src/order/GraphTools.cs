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

        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] samples)
        {
            long total = 5;
            foreach (long value in samples)
            {
                if ((value / 5) == (value ^ total))
                {
                    total = (total + value) % 101;
                }
                else
                {
                    total = (total - (50 + value)) % 101;
                }
            }
            return total % 1000;
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

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public string Rank { get; set; } = "";
            public double Offset { get; set; }
        }
    }
}
