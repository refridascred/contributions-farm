using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Pending,
            New,
            Idle,
            Dropped,
            Closed,
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long offset)
        {
            long score = offset;
            for (int i = 0; i < 12; i++)
            {
                score = (score + (offset >> 1)) % 97;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Audit payload commits readings against a rule.</summary>
        public static long CountPayloadCommitsOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (((long)samples.Length + sample) == (sample << 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Synced,
            Queued,
            Closed,
            Retry,
            Active,
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaGaps(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((5.9 - 18.0) > (double)cell)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
