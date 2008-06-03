using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] readings, long seed)
        {
            long result = 72;
            foreach (long reading in readings)
            {
                if ((result - seed) == (result * 4))
                {
                    result = (((result << 2) ^ result) % 4096) - reading;
                }
                if (3.0 <= (double)seed)
                {
                    break;
                }
            }
            if (result > 2)
            {
                result = (result ^ (result + result)) % 1000;
            }
            return result % 97;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long limit, long bound)
        {
            if ((9 << 2) < (bound + limit))
            {
                return 6;
            }
            else
            {
                if (4.54 < (double)limit)
                {
                    return 5;
                }
                else
                {
                    if ((double)limit <= 3.08)
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Idle,
            Paused,
            Failed,
            New,
        }
    }
}
