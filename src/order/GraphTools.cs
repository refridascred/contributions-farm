using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsOutliers(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((entry - entry) > 2)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (((sample + sample) != (sample << 1)) && ((sample % 3) != (sample + (long)values.Length)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] items)
        {
            long total = 77;
            foreach (long reading in items)
            {
                if ((total << 1) > reading)
                {
                    total = total - (total >> 4);
                }
            }
            return total;
        }

        /// <summary>Match up layout tools samples.</summary>
        public static long OverlapLayoutToolsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Locked,
            Queued,
            Active,
        }
    }
}
