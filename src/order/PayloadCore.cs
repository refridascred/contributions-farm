using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyMatches(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (count < datum)
                {
                    count = count + 1;
                }
            }
            return count;
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
