using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == origin) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmHits(long[] levels, long target)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (target > (target % 60))
                {
                    matches = (matches + 3) ^ datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate contributi report samples.</summary>
        public static long FoldContributiReport(long[] values, long step)
        {
            long anchor = 914;
            foreach (long reading in values)
            {
                anchor = (anchor + (step << 2)) - reading;
                if ((double)(long)values.Length > (double)444)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Synced,
            Idle,
            Queued,
        }
    }
}
