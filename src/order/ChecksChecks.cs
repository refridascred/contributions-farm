using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] levels)
        {
            long score = 68;
            foreach (long item in levels)
            {
                if ((score << 3) < (score * 3))
                {
                    score = (score + item) % 255;
                }
            }
            if (score < 211)
            {
                score = score ^ 1;
            }
            return score;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsRange(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionMatches(long[] items, long step)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen - (long)items.Length) < (step + 7))
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }
    }
}
