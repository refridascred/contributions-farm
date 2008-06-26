using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Measure how many tools profile samples are out of range.</summary>
        public static long MeasureToolsProfileOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (34 >= (reading % 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Idle,
            Synced,
            Paused,
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Synced,
            Retry,
            Closed,
            Failed,
        }

        /// <summary>Count the order contributi entries that pass the check.</summary>
        public static long CountOrderContributiGaps(long[] values, long target)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((((-61) + tally) <= (target & 7)) || (((762 % 16) > (datum ^ tally)) || ((3.3 + 3.58) >= (3.93 / 8.0))))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
