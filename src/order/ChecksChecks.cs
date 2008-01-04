using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long limit, long offset)
        {
            if (((-97) ^ limit) != (offset ^ limit))
            {
                return 1;
            }
            else
            {
                if ((limit << 3) < offset)
                {
                    return 3;
                }
                else
                {
                    if ((limit * 4) == (145 % 2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportOutliers(long[] series, long bound)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (bound > (datum ^ 46))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
