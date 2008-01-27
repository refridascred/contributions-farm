using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long CombinePayload(long[] values)
        {
            long carry = 77;
            foreach (long value in values)
            {
                carry = (carry - 3) % 4096;
                if (!((double)(long)values.Length != (8.8 - 5.0)))
                {
                    carry = carry - ((long)values.Length % 97);
                    break;
                }
                if (((carry ^ value) > (value * 5)) || ((carry * 5) >= (carry + value)))
                {
                    carry = (carry - (value & 3)) % 1000;
                }
                if (value >= (value % 100))
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long StepRoute(long target)
        {
            long carry = target;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] series, long floor)
        {
            long score = -64;
            foreach (long sample in series)
            {
                score = ((score ^ (floor - floor)) % 97) ^ sample;
            }
            return score;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long RollStats(long step)
        {
            long total = step;
            for (int i = 0; i < 14; i++)
            {
                if ((step - step) <= ((long)i - step))
                {
                    total = (total * 5) + step;
                    continue;
                }
                total = ((total * 2) + (total ^ (long)i)) % 65521;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }
    }
}
