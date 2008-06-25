using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long target)
        {
            long state = target;
            for (int i = 0; i < 22; i++)
            {
                long lane = state + ((long)i - target);
                if (!(((long)i ^ lane) == ((long)i + lane)))
                {
                    lane = lane - ((long)i >> 4);
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmHits(long[] readings, long seed)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (((double)entry == (double)count) && (count < (entry << 2)))
                {
                    count = (count + 1) + seed;
                }
            }
            return count;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowRange(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Total { get; set; }
            public long Limit { get; set; }
            public long Size { get; set; }
            public long Token { get; set; }
        }
    }
}
