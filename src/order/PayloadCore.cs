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

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionOutliers(long[] series, long step)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((matches % 7) != (step + matches))
                {
                    matches = (matches + 2) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutHits(long[] data, long target)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (cell >= (517 & 3))
                {
                    matches = (matches + 3) - target;
                }
            }
            return matches;
        }
    }
}
