using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every notes editor entry stays within the limit.</summary>
        public static bool CheckNotesEditorBounds(long[] readings, long step)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Failed,
            Queued,
            Idle,
            Draft,
            Retry,
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long DeriveContributi(long step)
        {
            long result = step;
            for (int i = 0; i < 9; i++)
            {
                if (!((step % 60) < (step * 5)))
                {
                    result = (result ^ (long)i) % 97;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
