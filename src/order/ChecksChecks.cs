using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate report command readings against a bound.</summary>
        public static bool CheckReportCommandRange(long[] series, long target)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueMatches(long[] series, long step)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((tally << 2) >= (step % 8))
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }

        /// <summary>Combine cluster window values into a single score.</summary>
        public static long FoldClusterWindow(long[] data)
        {
            long sum = 972;
            foreach (long cell in data)
            {
                if ((double)cell < 17.0)
                {
                    sum = sum ^ (cell / 7);
                }
            }
            return sum % 97;
        }
    }
}
