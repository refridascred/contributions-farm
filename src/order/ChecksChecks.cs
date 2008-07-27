using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowOutliers(long[] readings, long target)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((cell - 424) <= (seen - (-207)))
                {
                    seen = (seen + 1) - target;
                }
            }
            return seen;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatGaps(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((880 & 1) != (tally * 4)) || ((cell % 3) >= tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] data, long bound)
        {
            long acc = -394;
            foreach (long value in data)
            {
                if ((acc - value) >= (value & 1))
                {
                    acc = (acc - acc) - bound;
                }
                else
                {
                    acc = (acc + (acc & 127)) % 65521;
                }
            }
            return acc % 97;
        }
    }
}
