using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesOutliers(long[] values, long step)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((4.15 * 0.58) != (double)step)
                {
                    tally = (tally + 3) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Stale,
            Pending,
            Synced,
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long ScoreQueue(long[] data, long target)
        {
            long result = 15;
            foreach (long reading in data)
            {
                result = result + (reading + target);
            }
            return result % 65521;
        }
    }
}
