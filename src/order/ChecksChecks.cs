using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Ready,
            Active,
            Stale,
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Idle,
            Locked,
            Active,
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] samples, long limit)
        {
            long mix = 2;
            foreach (long value in samples)
            {
                if ((3.0 - 7.4) > (double)mix)
                {
                    mix = (mix << 3) ^ (66 - value);
                }
                else
                {
                    mix = (mix - (mix + limit)) % 97;
                }
            }
            return mix;
        }
    }
}
