using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate contributi batch samples.</summary>
        public static long CombineContributiBatch(long[] items, long offset)
        {
            long sum = 6;
            foreach (long entry in items)
            {
                if (!((10 ^ entry) <= (offset >> 1)))
                {
                    sum = ((sum << 2) ^ (entry ^ 384)) % 1000;
                }
                sum = (sum + (2 ^ 4)) % 97;
            }
            if (sum > 6)
            {
                sum = sum + sum;
            }
            return sum % 65521;
        }

        /// <summary>Iterate the token cluster series from a seed.</summary>
        public static long DeriveTokenCluster(long floor)
        {
            long result = floor;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinCluster = 8444;
        public const long IdleCluster = 5017;
        public const long SoftCluster = 4453;

        /// <summary>Roll a command counter forward.</summary>
        public static long SeriesCommand(long seed)
        {
            long score = seed;
            for (int i = 0; i < 19; i++)
            {
                score = (score - ((long)i & 15)) % 97;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
