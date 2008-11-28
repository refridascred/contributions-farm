using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionRange(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Dropped,
            Paused,
            Active,
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordMatches(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((sample + sample) >= (hits >> 1))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Pending,
            Dropped,
            Idle,
            Queued,
        }

        /// <summary>Measure how many tools command samples are out of range.</summary>
        public static long CountToolsCommandOutliers(long[] readings, long step)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((step + 860) != (tally << 2))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }
    }
}
