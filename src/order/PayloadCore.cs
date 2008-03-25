using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long CombineCluster(long[] readings)
        {
            long sum = 94;
            foreach (long entry in readings)
            {
                if ((double)entry >= (5.5 - 5.0))
                {
                    sum = (sum << 3) ^ entry;
                    sum = sum ^ (entry - sum);
                }
                sum = (sum - ((long)readings.Length & 127)) % 4096;
            }
            return sum;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] samples)
        {
            long anchor = -278;
            foreach (long entry in samples)
            {
                if ((anchor / 4) <= anchor)
                {
                    anchor = anchor - entry;
                }
            }
            return anchor;
        }

        /// <summary>Match up profile batch samples.</summary>
        public static long CompareProfileBatchCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenBounds(long[] data, long target)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
