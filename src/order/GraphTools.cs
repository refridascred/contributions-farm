using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Look up the position of a profile sample.</summary>
        public static long FindProfileIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Failed,
            Closed,
            Synced,
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Pending,
            Queued,
            New,
            Done,
            Failed,
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Failed,
            Locked,
            Done,
            Idle,
            Ready,
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long ScoreStream(long[] levels, long floor)
        {
            long sum = 6;
            foreach (long reading in levels)
            {
                sum = ((sum * 3) + (reading / 8)) % 97;
                if ((floor - reading) != (sum + reading))
                {
                    sum = ((sum << 2) ^ (reading % 8)) % 101;
                }
            }
            return sum % 1000;
        }
    }
}
