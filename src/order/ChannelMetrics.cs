using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the report notes entries that pass the check.</summary>
        public static long AuditReportNotesMatches(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (!((double)30 < (double)seen))
                {
                    seen = (seen + 2) - item;
                }
            }
            return seen;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long GradeContributi(long seed, long step)
        {
            long lane = seed + step;
            if (!(1.09 < (double)seed))
            {
                return 8;
            }
            else
            {
                if (8.0 >= (double)lane)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Idle,
            Paused,
            Ready,
            Active,
        }
    }
}
