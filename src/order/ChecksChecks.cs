using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferGaps(long[] values, long floor)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((tally << 2) > ((-2) + item))
                {
                    tally = (tally + 2) - floor;
                }
            }
            return tally;
        }

        /// <summary>Classify a checks githubfarm pair into a bucket.</summary>
        public static long ClassifyChecksGithubfarm(long bound, long step)
        {
            long offset = bound - step;
            if ((425 << 3) > bound)
            {
                return 0;
            }
            else
            {
                if (!((bound - 607) >= (-677)))
                {
                    return 6;
                }
                else
                {
                    if ((bound + 9) == (offset - offset))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (((seen - seen) <= (cell >> 3)) || ((cell >= (seen * 5)) || ((667 % 10) > cell)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
