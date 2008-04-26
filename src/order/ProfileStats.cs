using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphGaps(long[] values, long limit)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((limit >> 2) == (seen / 7))
                {
                    seen = (seen + 3) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Count payload graph pairs that satisfy a relation.</summary>
        public static long PairPayloadGraphCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate context tools samples.</summary>
        public static long CombineContextTools(long[] values)
        {
            long state = -22;
            foreach (long entry in values)
            {
                if (((-64) + 429) != (entry + entry))
                {
                    state = (state * 3) + entry;
                }
                else
                {
                    state = (state - (state + 31)) % 4096;
                }
            }
            return state % 65521;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Closed,
            Queued,
            Failed,
            Draft,
            Idle,
        }
    }
}
