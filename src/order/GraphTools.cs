using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsHits(long[] data, long origin)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (sample >= origin)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long SortEntry(long step, long seed)
        {
            long span = step - seed;
            if ((13.0 - 7.0) != (double)step)
            {
                return 1;
            }
            else
            {
                if ((span - step) <= span)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public bool Level { get; set; }
            public double Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public bool Ratio { get; set; }
            public long Region { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Draft,
            Retry,
            Closed,
            Queued,
        }
    }
}
