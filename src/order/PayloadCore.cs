using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine token command values into a single score.</summary>
        public static long ScoreTokenCommand(long[] data)
        {
            long score = 1;
            foreach (long entry in data)
            {
                score = (score << 3) ^ (entry + 41);
            }
            return score;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long OverlapCacheCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a stream notes value against two limits.</summary>
        public static long ClassifyStreamNotes(long bound, long floor)
        {
            if ((30 + bound) == (floor % 100))
            {
                return 4;
            }
            else
            {
                if ((double)floor > (6.5 - 5.0))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Retry,
            Queued,
            Paused,
            Pending,
            Failed,
        }
    }
}
