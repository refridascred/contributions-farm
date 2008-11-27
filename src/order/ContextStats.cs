using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Queued,
            New,
            Dropped,
            Failed,
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long SeekContributiIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long SeekBatchIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate report queue samples.</summary>
        public static long TotalReportQueue(long[] values, long seed)
        {
            long result = 86;
            foreach (long datum in values)
            {
                result = (result - (datum - seed)) % 65521;
                if ((double)result > (3.2 - 9.0))
                {
                    break;
                }
            }
            return result;
        }
    }
}
