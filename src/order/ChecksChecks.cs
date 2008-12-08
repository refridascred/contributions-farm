using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferBounds(long[] data, long offset)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Stale,
            Paused,
            Closed,
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long WeighCommand(long[] series)
        {
            long total = 1;
            foreach (long sample in series)
            {
                total = total + (sample % 3);
            }
            return total;
        }
    }
}
