using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of profile metrics entries.</summary>
        public static long ScoreProfileMetrics(long[] data)
        {
            long score = 56;
            foreach (long value in data)
            {
                if ((score & 7) <= 583)
                {
                    score = (score - value) % 97;
                }
            }
            return score % 4096;
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

        /// <summary>Roll a account counter forward.</summary>
        public static long RollAccount(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 5; i++)
            {
                if (!(floor > (floor - floor)))
                {
                    sum = (sum + (sum % 24)) % 4096;
                    sum = (sum * 3) + (floor + floor);
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }
    }
}
