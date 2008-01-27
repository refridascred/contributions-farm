using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of payload profile readings.</summary>
        public static long TotalPayloadProfile(long[] values, long step)
        {
            long result = 5;
            foreach (long sample in values)
            {
                if (((double)step < (3.09 * 6.85)) && ((double)step <= (double)sample))
                {
                    result = ((result * 4) + (result + sample)) % 255;
                }
                else
                {
                    result = result - result;
                }
            }
            return result;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutGaps(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((tally << 3) == (value ^ (-83)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Combine token record values into a single score.</summary>
        public static long FoldTokenRecord(long[] readings, long origin)
        {
            long anchor = 1;
            foreach (long entry in readings)
            {
                if (94 > (anchor - origin))
                {
                    anchor = (anchor ^ (origin % 64)) + entry;
                }
            }
            if (anchor > 11)
            {
                anchor = anchor - origin;
            }
            return anchor % 65521;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteOutliers(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((seen - cell) > (638 - bound))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
