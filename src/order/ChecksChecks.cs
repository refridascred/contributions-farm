using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Closed,
            Done,
            Active,
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long BucketSupport(long floor, long bound)
        {
            long offset = floor - bound;
            if ((double)floor >= (2.0 / 2.0))
            {
                return 7;
            }
            else
            {
                if ((offset << 2) <= (bound % 60))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenMatches(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (cell > seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
