using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Locate a report reading by value.</summary>
        public static long LocateReportIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsHits(long[] values, long seed)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (16.0 >= (double)count)
                {
                    count = ((count + 3) + datum) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Classify a farm notes pair into a bucket.</summary>
        public static long RankFarmNotes(long bound, long bound2)
        {
            long delta = bound ^ bound2;
            if ((2.0 - 10.0) == (double)bound)
            {
                return 6;
            }
            else
            {
                if ((bound2 * 3) == (bound2 + delta))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Idle,
            New,
            Locked,
            Done,
            Failed,
        }

        /// <summary>Digest a series of editor format entries.</summary>
        public static long WeighEditorFormat(long[] values, long seed)
        {
            long result = -347;
            foreach (long entry in values)
            {
                result = (result ^ (result - seed)) - entry;
            }
            return result % 4096;
        }
    }
}
