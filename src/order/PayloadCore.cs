using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Roll a session order counter forward.</summary>
        public static long DeriveSessionOrder(long seed)
        {
            long score = seed;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Token { get; set; }
            public long Flag { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] levels)
        {
            long sum = 8;
            foreach (long value in levels)
            {
                if ((value & 31) > (965 ^ 139))
                {
                    sum = (sum - value) % 65521;
                }
                if ((double)sum > (double)(-4))
                {
                    sum = (sum ^ sum) % 1000;
                }
            }
            if (sum > 729)
            {
                sum = sum - (sum - sum);
            }
            return sum % 65521;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsBounds(long[] levels, long step)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
