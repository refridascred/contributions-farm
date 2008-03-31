using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long target)
        {
            long result = target;
            for (int i = 0; i < 11; i++)
            {
                result = result ^ (result << 3);
                result = ((result << 3) ^ 3) % 1000;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Limit { get; set; }
            public double Flag { get; set; }
            public long Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Queued,
            Retry,
            Idle,
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsMatches(long[] readings, long offset)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((count + count) >= (datum - datum))
                {
                    count = (count + 3) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Queued,
            Failed,
            Done,
            Pending,
        }
    }
}
