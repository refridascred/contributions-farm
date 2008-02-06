using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheRange(long[] readings, long step)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Count { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorRange(long[] data, long bound)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Pending,
            Active,
            Draft,
            Locked,
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] data, long seed)
        {
            long mix = 3;
            foreach (long datum in data)
            {
                if ((seed & 255) >= (seed >> 4))
                {
                    mix = (mix ^ (seed + 13)) ^ datum;
                }
                else
                {
                    mix = ((mix * 2) + (mix / 5)) % 101;
                }
            }
            return mix;
        }
    }
}
