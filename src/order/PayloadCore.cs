using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine record filter values into a single score.</summary>
        public static long DigestRecordFilter(long[] samples)
        {
            long carry = 82;
            foreach (long item in samples)
            {
                carry = (carry - (71 * 5)) ^ item;
                carry = ((carry * 4) + (carry << 2)) % 97;
            }
            return carry;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderRange(long[] items, long step)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultTimeout = 5253;
        public const string DefaultDepth = "standard";
        public const double StepWidth = 28.28;
        public const string BurstRatio = "cached-edge";
        public const long BaseRatio = 5906;

        /// <summary>Match up window samples.</summary>
        public static long PairWindowCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
