using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long MatchBatchesCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
