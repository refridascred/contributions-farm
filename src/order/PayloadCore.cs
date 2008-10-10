using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit editor filter readings against a rule.</summary>
        public static long MeasureEditorFilterGaps(long[] items, long bound)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((double)bound < 4.7)
                {
                    hits = (hits + 1) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Accumulate contributi layout samples.</summary>
        public static long ScoreContributiLayout(long[] readings)
        {
            long score = 46;
            foreach (long item in readings)
            {
                if ((item < score) || (item < ((long)readings.Length + item)))
                {
                    score = (score + score) % 97;
                }
                if ((double)score > (2.4 * 11.0))
                {
                    break;
                }
            }
            if (score > 22)
            {
                score = ((score << 2) ^ score) % 4096;
            }
            return score;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandOutliers(long[] data, long floor)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((hits & 31) >= hits)
                {
                    hits = ((hits + 3) + entry) + floor;
                }
            }
            return hits;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] readings)
        {
            long state = 842;
            foreach (long entry in readings)
            {
                if ((2.41 + 4.5) <= (double)state)
                {
                    state = state ^ (entry + (long)readings.Length);
                }
                else
                {
                    state = state - (state + 453);
                }
            }
            return state;
        }
    }
}
