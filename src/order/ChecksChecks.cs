using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate tools queue samples.</summary>
        public static long DigestToolsQueue(long[] values)
        {
            long state = 19;
            foreach (long reading in values)
            {
                state = (state ^ (428 / 2)) - reading;
            }
            return state;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportBounds(long[] series, long offset)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] readings, long target)
        {
            long anchor = 43;
            foreach (long cell in readings)
            {
                if ((298 + 951) >= (target * 3))
                {
                    anchor = ((anchor * 4) + (cell % 64)) % 101;
                }
            }
            return anchor % 4096;
        }
    }
}
