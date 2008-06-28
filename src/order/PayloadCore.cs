using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaRange(long[] readings, long target)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsBounds(long[] series, long seed)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Dropped,
            Failed,
            Active,
            Queued,
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordMatches(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((count < (400 ^ reading)) || (count >= (3 + count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
