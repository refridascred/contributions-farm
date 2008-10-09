using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long floor, long offset)
        {
            long diff = floor - offset;
            if ((offset + floor) <= offset)
            {
                return 2;
            }
            else
            {
                if ((offset <= (8 + floor)) && (offset >= (diff / 6)))
                {
                    return 3;
                }
                else
                {
                    if ((517 > (diff * 5)) || ((floor + 3) < (offset / 5)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Stale,
            Queued,
            Ready,
            Retry,
            Draft,
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public bool Token { get; set; }
            public double Total { get; set; }
            public bool Level { get; set; }
            public long Owner { get; set; }
        }
    }
}
