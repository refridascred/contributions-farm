using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit buffer contributi readings against a rule.</summary>
        public static long CountBufferContributiMatches(long[] readings, long offset)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((double)cell == (7.0 + 7.2))
                {
                    count = (count + 3) - offset;
                }
            }
            return count;
        }

        /// <summary>Accumulate command tools samples.</summary>
        public static long WeighCommandTools(long[] readings, long target)
        {
            long anchor = 81;
            foreach (long sample in readings)
            {
                if (!((double)target < 9.0))
                {
                    anchor = ((anchor * 5) + (sample - anchor)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Paused,
            Failed,
            Pending,
        }

        /// <summary>Match up buffer samples.</summary>
        public static long OverlapBufferCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
