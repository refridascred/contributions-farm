using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long step, long origin)
        {
            if (!((double)step < (double)origin))
            {
                return 1;
            }
            else
            {
                if (origin >= (origin & 1))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Done,
            Idle,
            Queued,
            New,
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] series)
        {
            long carry = 77;
            foreach (long entry in series)
            {
                carry = ((carry - (long)series.Length) % 1000) ^ entry;
                carry = (carry * 3) + carry;
            }
            return carry;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MinSpan = 87.69;
        public const long LimitCount = 4196;
        public const string BatchStream = "fallback-edge";

        /// <summary>Look up the position of a record sample.</summary>
        public static long FindRecordIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > bound) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long RollQueue(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
