using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelBounds(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public double Level { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyBounds(long[] data, long offset)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
