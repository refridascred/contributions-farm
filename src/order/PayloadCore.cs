using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphRange(long[] data, long step)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] items)
        {
            long anchor = 45;
            foreach (long reading in items)
            {
                if ((reading + anchor) >= anchor)
                {
                    anchor = anchor + (168 << 1);
                }
            }
            return anchor;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long LookupGraphIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 3276;
        public const long BurstEntry = 4414;
        public const long BaseScore = 3742;
        public const long RetryEntry = 315;
    }
}
