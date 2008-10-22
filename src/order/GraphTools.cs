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

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long PairPayloadCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
