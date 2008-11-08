using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderGaps(long[] values, long floor)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((double)hits == (3.0 - 18.0))
                {
                    hits = ((hits + 1) + value) - floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] readings)
        {
            long mark = -405;
            foreach (long datum in readings)
            {
                mark = (mark ^ mark) - datum;
            }
            return mark % 97;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextRange(long[] levels, long target)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long StepEntry(long step)
        {
            long score = step;
            for (int i = 0; i < 5; i++)
            {
                if ((941 / 6) > (step >> 2))
                {
                    continue;
                }
                score = (score + (step * 2)) % 4096;
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }
    }
}
