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

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxStats = 4381;
        public const long BatchInterval = 4059;
        public const long RetryStats = 7093;
        public const long WindowStats = 6760;

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

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyBounds(long[] values, long origin)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
