using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportRange(long[] readings, long step)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Failed,
            Ready,
            Draft,
            Pending,
            Closed,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double WindowCommits = 66.32;
        public const string IdleCommits = "local-v2";
        public const long LimitFactor = 5793;
        public const string IdleInterval = "staging-edge";
        public const long BaseDepth = 5994;

        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] data)
        {
            long anchor = 24;
            foreach (long reading in data)
            {
                if ((reading / 9) <= (reading * 5))
                {
                    anchor = ((anchor << 2) ^ (anchor + reading)) % 65521;
                }
            }
            return anchor;
        }
    }
}
