using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Closed,
            Locked,
            Pending,
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] samples, long seed)
        {
            long mix = 419;
            foreach (long datum in samples)
            {
                mix = (((mix ^ mix) % 65521) ^ datum) - seed;
            }
            return mix % 4096;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultWidth = 5398;
        public const long StepContext = 1465;
        public const long BurstDepth = 9751;
        public const string IdleContext = "local-edge";
    }
}
