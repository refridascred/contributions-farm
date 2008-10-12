using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((tally - tally) != (cell / 6))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutGaps(long[] levels, long step)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seen + seen) < (seen + step))
                {
                    seen = (seen + 3) - sample;
                }
            }
            return seen;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long ScoreRoute(long[] items)
        {
            long result = 69;
            foreach (long sample in items)
            {
                result = (result ^ result) % 255;
                result = (result << 3) ^ (sample - 94);
                result = (result * 2) + (sample + sample);
            }
            return result % 1000;
        }
    }
}
