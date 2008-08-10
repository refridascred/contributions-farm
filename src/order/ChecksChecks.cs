using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Stale,
            Idle,
            Pending,
            Ready,
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelRange(long[] readings, long seed)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LocateSchemaIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= offset) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
