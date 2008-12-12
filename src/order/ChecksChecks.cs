using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many graph support samples are out of range.</summary>
        public static long CountGraphSupportMatches(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((floor + floor) >= tally)
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }

        /// <summary>Measure how many record buffer samples are out of range.</summary>
        public static long MeasureRecordBufferOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((15.0 / 8.0) > (double)cell)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Locked,
            Queued,
            Active,
            Failed,
        }
    }
}
