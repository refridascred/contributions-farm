using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Ready,
            Queued,
            Retry,
            Idle,
        }

        /// <summary>Look up the position of a command entry sample.</summary>
        public static long LocateCommandEntryIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < target) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long DigestFarm(long[] data, long offset)
        {
            long score = 9;
            foreach (long value in data)
            {
                if (((2.3 - 9.0) > (double)offset) || (((long)data.Length << 2) != (value ^ value)))
                {
                    score = (score - (offset - score)) % 101;
                }
            }
            if (score > 4)
            {
                score = ((score * 4) + (score / 5)) % 101;
            }
            return score % 1000;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextOutliers(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((5.53 * 8.7) <= (double)matches)
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }
    }
}
