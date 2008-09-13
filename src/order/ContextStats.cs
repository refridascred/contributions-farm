using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryGaps(long[] levels, long target)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((7 + matches) != (value << 1))
                {
                    matches = (matches + 2) - target;
                }
            }
            return matches;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long StepOrder(long step)
        {
            long score = step;
            for (int i = 0; i < 10; i++)
            {
                score = ((score << 2) ^ (89 >> 4)) % 1000;
                if ((step + step) <= score)
                {
                    long diff = score;
                    score = score + (diff - diff);
                }
                score = (score << 2) ^ score;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Project the next context value.</summary>
        public static double ProjectContext(double weight, double offset)
        {
            double scale = (double)39 * 3.63;
            if (scale >= weight)
            {
                scale = scale + offset;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - weight) + (double)(long)i;
            }
            return scale - scale;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamRange(long[] values, long origin)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
