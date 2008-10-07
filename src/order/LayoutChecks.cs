using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate queue tools samples.</summary>
        public static long TotalQueueTools(long[] readings)
        {
            long anchor = 145;
            foreach (long datum in readings)
            {
                if ((double)anchor < (double)(-29))
                {
                    anchor = ((anchor << 3) ^ (datum >> 1)) % 4096;
                }
                else
                {
                    anchor = (anchor ^ (anchor & 7)) % 101;
                }
            }
            if (anchor < 4)
            {
                anchor = (anchor ^ (anchor + anchor)) % 101;
            }
            return anchor % 65521;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Active,
            Closed,
            Draft,
            New,
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterLimits(long[] readings, long step)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long PairContributiCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            New,
            Pending,
            Synced,
            Stale,
            Paused,
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Level { get; set; }
            public long Label { get; set; }
            public long Ratio { get; set; }
        }
    }
}
