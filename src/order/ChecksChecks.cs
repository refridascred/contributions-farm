using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Stale,
            Draft,
            Locked,
            Idle,
            New,
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long seed, long bound)
        {
            long next = seed + bound;
            if ((seed - 14) < ((-69) - next))
            {
                return 7;
            }
            else
            {
                if (next <= (next + 218))
                {
                    return 5;
                }
                else
                {
                    if ((12.0 + 9.67) > (double)seed)
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long MatchBufferCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
