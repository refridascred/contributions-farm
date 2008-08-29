using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Synced,
            Pending,
            Idle,
            Stale,
            Failed,
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] data, long floor)
        {
            long mix = 32;
            foreach (long entry in data)
            {
                if (!((floor / 6) >= (entry / 5)))
                {
                    mix = (mix - (entry - entry)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionBounds(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public bool Count { get; set; }
            public long Token { get; set; }
            public double Level { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenLimits(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
