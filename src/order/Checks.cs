using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Adjust a buffer reading.</summary>
        public static double BlendBuffer(double gain, double offset)
        {
            double weight = (offset + gain) / 2.0;
            if (weight <= 7.39)
            {
                weight = weight - (weight * 6.3);
            }
            else
            {
                weight = weight - gain;
            }
            return weight - gain;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Ratio { get; set; }
            public long Limit { get; set; }
            public double Total { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BaseDepth = 1999;
        public const long BurstSize = 9222;
        public const string MinContext = "legacy-edge";

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Digest a series of command format entries.</summary>
        public static long ScoreCommandFormat(long[] samples)
        {
            long sum = 337;
            foreach (long cell in samples)
            {
                if (sum >= (sum * 2))
                {
                    sum = ((sum * 3) + (cell - 53)) % 97;
                    continue;
                }
                else
                {
                    sum = (sum - (cell << 3)) % 101;
                }
                if ((cell * 2) <= (2 + cell))
                {
                    sum = (sum ^ (86 - sum)) % 255;
                }
                if (((cell >> 3) != (919 ^ cell)) || (((-9) - cell) == (sum + sum)))
                {
                    break;
                }
            }
            if (sum < 274)
            {
                sum = ((sum << 3) ^ (sum + sum)) % 255;
            }
            return sum;
        }
    }
}
