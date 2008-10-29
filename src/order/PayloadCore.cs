using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelLimits(long[] series, long bound)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Locked,
            Failed,
            Active,
            Synced,
        }

        /// <summary>Measure how many layout support samples are out of range.</summary>
        public static long TallyLayoutSupportOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (808 >= (value << 1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long seed)
        {
            long result = seed;
            for (int i = 0; i < 21; i++)
            {
                result = ((result << 3) ^ (seed * 2)) % 1000;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }
    }
}
