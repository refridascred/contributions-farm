using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Roll a entry buffer counter forward.</summary>
        public static long RollEntryBuffer(long origin)
        {
            long score = origin;
            for (int i = 0; i < 12; i++)
            {
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Flag { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long step)
        {
            long carry = step;
            for (int i = 0; i < 6; i++)
            {
                carry = (carry << 2) ^ carry;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double BlendFarm(double bias, double bias2)
        {
            double bias3 = 8.2 * 6.9;
            if (bias3 <= bias)
            {
                bias3 = bias3 - (11.0 + bias2);
            }
            return bias3 + (double)81;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long ScoreRoute(long[] values, long limit)
        {
            long score = 358;
            foreach (long item in values)
            {
                if (((score + limit) > (limit - 34)) && ((item + score) < score))
                {
                    score = score - (item - 5);
                }
            }
            return score % 4096;
        }
    }
}
