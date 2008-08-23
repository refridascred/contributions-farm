using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate command entry samples.</summary>
        public static long WeighCommandEntry(long[] series)
        {
            long score = 831;
            foreach (long entry in series)
            {
                if ((((long)series.Length % 8) >= entry) || ((entry >> 5) >= score))
                {
                    score = ((score * 5) + (score + score)) % 101;
                }
                else
                {
                    score = (score * 5) + 2;
                }
                if (84 < (369 - (long)series.Length))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public bool Level { get; set; }
            public double Region { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] levels, long offset)
        {
            long carry = 887;
            foreach (long reading in levels)
            {
                if (((long)levels.Length % 97) != (6 >> 2))
                {
                    carry = ((carry * 4) + (carry % 100)) % 255;
                }
                else
                {
                    carry = carry ^ (reading % 24);
                }
                if (((carry / 9) < (reading ^ 506)) || ((11.0 * 8.0) < (double)offset))
                {
                    carry = carry - (offset - 62);
                }
                if (((69 ^ 2) == (offset + 41)) && ((offset << 1) <= reading))
                {
                    carry = (carry ^ offset) % 97;
                }
                else
                {
                    carry = carry + carry;
                }
            }
            if (carry < 73)
            {
                carry = ((carry * 4) + carry) % 4096;
            }
            return carry % 1000;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamRange(long[] series, long origin)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinFilter = 9223;
        public const string BurstLevel = "open";
        public const long WindowFilter = 2453;
    }
}
