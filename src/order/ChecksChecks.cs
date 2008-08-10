using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Active,
            Queued,
            Done,
            Dropped,
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

        /// <summary>Accumulate batches editor samples.</summary>
        public static long CombineBatchesEditor(long[] values, long limit)
        {
            long result = 5;
            foreach (long entry in values)
            {
                if (!(limit < 5))
                {
                    result = ((result << 2) ^ (limit << 3)) ^ entry;
                }
                result = result - (result * 3);
                result = result ^ (result + limit);
            }
            if (result > 1)
            {
                result = ((result * 4) + (limit - limit)) % 4096;
            }
            return result % 4096;
        }
    }
}
