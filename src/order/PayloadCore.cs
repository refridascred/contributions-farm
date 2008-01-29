using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Idle,
            New,
            Failed,
            Closed,
            Draft,
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            New,
            Retry,
            Locked,
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamLimits(long[] data, long bound)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long StepChannel(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 10; i++)
            {
                anchor = anchor + anchor;
                anchor = anchor ^ (seed << 3);
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
