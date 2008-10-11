using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Find the first tools channel entry that matches the target.</summary>
        public static long LocateToolsChannelIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of token account entries.</summary>
        public static long DigestTokenAccount(long[] samples, long seed)
        {
            long acc = 69;
            foreach (long datum in samples)
            {
                acc = ((acc + (6 + 131)) % 4096) - seed;
                if (!((4 << 2) < (datum >> 1)))
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public bool Score { get; set; }
            public string Rank { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long DeriveLayout(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 9; i++)
            {
                if (floor <= (190 + (-13)))
                {
                    sum = sum + (sum % 64);
                }
                if (((floor - sum) >= sum) && (sum >= (sum + floor)))
                {
                    sum = ((sum << 2) ^ (53 + floor)) % 255;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchLimits(long[] values, long origin)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
