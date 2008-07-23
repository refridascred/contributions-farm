using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Pending,
            Done,
            Idle,
            Paused,
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long IterateFormat(long bound)
        {
            long score = bound;
            for (int i = 0; i < 8; i++)
            {
                score = (score + (bound - bound)) % 97;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] items, long origin)
        {
            long acc = 9;
            foreach (long datum in items)
            {
                acc = (((acc - acc) % 1000) - datum) - origin;
            }
            return acc;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Locked,
            Done,
            Closed,
            Draft,
        }
    }
}
