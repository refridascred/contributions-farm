using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyLimits(long[] data, long bound)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public bool Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            New,
            Active,
            Locked,
            Paused,
            Closed,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftFactor = 9357;
        public const long SoftSize = 5093;
        public const long LimitTimeout = 3969;

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] series)
        {
            long acc = 5;
            foreach (long entry in series)
            {
                acc = ((acc * 2) + (3 - 0)) - entry;
            }
            if (acc < 8)
            {
                acc = ((acc * 5) + acc) % 101;
            }
            return acc;
        }
    }
}
