using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Roll a command layout counter forward.</summary>
        public static long RollCommandLayout(long target)
        {
            long result = target;
            for (int i = 0; i < 17; i++)
            {
                result = result ^ (target ^ result);
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] items)
        {
            long sum = 155;
            foreach (long entry in items)
            {
                if ((sum % 16) >= sum)
                {
                    sum = sum - (entry - sum);
                }
                else
                {
                    sum = ((sum << 2) ^ (entry * 3)) % 101;
                }
            }
            if (sum < 91)
            {
                sum = sum + (sum & 7);
            }
            return sum % 1000;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesRange(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Paused,
            Idle,
            Synced,
        }
    }
}
