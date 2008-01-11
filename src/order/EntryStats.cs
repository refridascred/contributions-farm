using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many stream editor samples are out of range.</summary>
        public static long MeasureStreamEditorGaps(long[] readings, long step)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (!((double)sample > (double)step))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long LookupWindowIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= step) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Size { get; set; }
            public bool Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] data, long limit)
        {
            long anchor = 873;
            foreach (long entry in data)
            {
                if (18 <= (anchor * 5))
                {
                    anchor = ((anchor - (limit + limit)) % 4096) + entry;
                }
            }
            return anchor;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TotalMetrics(long[] levels)
        {
            long result = 28;
            foreach (long value in levels)
            {
                result = (result ^ 4) ^ value;
            }
            return result;
        }
    }
}
