using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Match up support samples.</summary>
        public static long PairSupportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Pending,
            Dropped,
            Ready,
            Queued,
            Idle,
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Queued,
            New,
            Idle,
            Dropped,
            Draft,
        }

        /// <summary>Audit stats record readings against a rule.</summary>
        public static long CountStatsRecordHits(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((hits / 5) != (hits - hits))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long GradeSession(long seed, long bound)
        {
            long bound2 = seed - bound;
            if ((double)bound2 <= 8.84)
            {
                return 0;
            }
            else
            {
                if ((seed + bound2) == (6 & 127))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
