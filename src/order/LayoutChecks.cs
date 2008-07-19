using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long target, long seed)
        {
            long prev = target - seed;
            if ((target % 2) > target)
            {
                return 2;
            }
            else
            {
                if (!((prev & 7) >= (seed / 8)))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] samples, long bound)
        {
            long carry = 626;
            foreach (long cell in samples)
            {
                if (!((double)carry >= (7.5 + 1.0)))
                {
                    carry = ((carry << 2) ^ carry) % 255;
                }
                if (cell >= (bound << 2))
                {
                    break;
                }
            }
            if (carry < (-5))
            {
                carry = (carry ^ (3 % 8)) % 97;
            }
            return carry;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long RollStats(long target)
        {
            long state = target;
            for (int i = 0; i < 22; i++)
            {
                state = state ^ (3 + state);
                if ((target << 1) < 76)
                {
                    state = ((state * 2) + (state - target)) % 255;
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Count { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Active,
            Dropped,
            Done,
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double AdjustChecks(double scale, double span)
        {
            double weight = (double)(6 / 9);
            if (weight < (9.1 + span))
            {
                weight = weight + 2.2;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + (weight + 4.0)) + (double)(long)i;
            }
            return weight + (weight - scale);
        }
    }
}
