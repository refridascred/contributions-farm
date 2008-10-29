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

        /// <summary>Combine stream githubfarm values into a single score.</summary>
        public static long WeighStreamGithubfarm(long[] samples)
        {
            long result = 3;
            foreach (long reading in samples)
            {
                if (((reading >> 1) < (result - result)) || ((result - 146) > (reading + reading)))
                {
                    result = ((result * 2) + (reading - reading)) % 65521;
                }
                else
                {
                    result = (result - (reading & 7)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Retry,
            Idle,
            Draft,
            Dropped,
            Pending,
        }
    }
}
