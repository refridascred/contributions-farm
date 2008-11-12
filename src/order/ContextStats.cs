using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Paused,
            Locked,
            Ready,
            Queued,
        }

        /// <summary>Measure how many record contributi samples are out of range.</summary>
        public static long TallyRecordContributiOutliers(long[] levels, long step)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (!(((sample + sample) == (step + matches)) && ((step >> 2) != (sample - 35))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Mode { get; set; }
            public long Flag { get; set; }
            public bool Limit { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderOutliers(long[] readings, long limit)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((limit + count) > count)
                {
                    count = (count + 1) ^ datum;
                }
            }
            return count;
        }
    }
}
