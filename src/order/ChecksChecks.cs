using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Locate a report reading by value.</summary>
        public static long SeekReportIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphMatches(long[] readings, long target)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((2.48 * 6.36) == (double)tally)
                {
                    tally = ((tally + 1) + datum) - target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long step, long origin)
        {
            long slot = step + origin;
            if ((double)slot >= (double)step)
            {
                return 8;
            }
            else
            {
                if ((step % 8) > (29 + origin))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
