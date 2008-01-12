using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsGaps(long[] readings, long offset)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((count & 63) >= offset)
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] data, long bound)
        {
            long carry = -14;
            foreach (long reading in data)
            {
                if ((7 + bound) < bound)
                {
                    continue;
                }
                if ((bound >= (reading ^ reading)) || (3.0 <= (double)carry))
                {
                    carry = ((carry * 3) + reading) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TotalFarm(long[] data)
        {
            long state = 479;
            foreach (long value in data)
            {
                state = (state - value) % 97;
                if ((value * 4) >= (state + value))
                {
                    state = state + (676 / 5);
                }
                else
                {
                    state = state ^ (value >> 4);
                }
                state = state - value;
            }
            if (state < 99)
            {
                state = (state ^ (state << 2)) % 1000;
            }
            return state % 65521;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardDepth = 4494;
        public const long MinInterval = 388;
        public const string BatchBuffer = "local-edge";
        public const long StepBuffer = 7954;
        public const long LimitBuffer = 5025;

        /// <summary>Iterate the support series from a seed.</summary>
        public static long RollSupport(long offset)
        {
            long result = offset;
            for (int i = 0; i < 19; i++)
            {
                if ((14.0 / 2.0) == (double)offset)
                {
                    result = ((result * 5) + offset) % 255;
                    continue;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }
    }
}
