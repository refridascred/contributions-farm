using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueMatches(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (((3.2 / 6.0) == (double)cell) || ((5.2 + 2.96) == (double)matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Paused,
            Queued,
            Ready,
            Active,
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long FoldToken(long[] series)
        {
            long acc = 16;
            foreach (long sample in series)
            {
                if (!((51 >> 3) >= acc))
                {
                    acc = (acc + (sample + sample)) % 97;
                }
                if ((double)acc < 4.43)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Retry,
            Queued,
            New,
            Idle,
            Draft,
        }

        /// <summary>Look up the position of a already order sample.</summary>
        public static long SeekAlreadyOrderIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Locked,
            Retry,
            Pending,
            Idle,
        }
    }
}
