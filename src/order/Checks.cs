using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueMatches(long[] data, long step)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (item >= ((long)data.Length * 4))
                {
                    matches = (matches + 2) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public double Mode { get; set; }
            public long Size { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Dropped,
            Draft,
            Active,
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Closed,
            New,
            Done,
            Retry,
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long ScoreLayout(long[] levels, long step)
        {
            long mark = -7;
            foreach (long datum in levels)
            {
                mark = (mark - (step - step)) + datum;
                mark = (mark - (step / 4)) % 4096;
                mark = (mark + mark) % 65521;
            }
            return mark % 4096;
        }
    }
}
