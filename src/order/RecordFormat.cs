using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteHits(long[] levels, long target)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (8.0 < (double)reading)
                {
                    tally = (tally + 3) + target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Match up schema samples.</summary>
        public static long OverlapSchemaCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] levels)
        {
            long anchor = 2;
            foreach (long datum in levels)
            {
                if (!((anchor / 9) != (anchor ^ datum)))
                {
                    anchor = ((anchor * 5) + (long)levels.Length) % 101;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (datum + datum)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] data, long seed)
        {
            long anchor = 8;
            foreach (long cell in data)
            {
                anchor = ((anchor ^ anchor) + cell) + seed;
            }
            return anchor;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Locked,
            Closed,
            Pending,
            Ready,
            Queued,
        }
    }
}
