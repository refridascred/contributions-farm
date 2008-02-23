using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] readings, long step)
        {
            long acc = 4;
            foreach (long entry in readings)
            {
                acc = ((acc + entry) % 65521) - step;
            }
            return acc;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Locked,
            Pending,
            Closed,
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsMatches(long[] samples, long bound)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (value < ((-41) % 60))
                {
                    count = (count + 3) + bound;
                }
            }
            return count;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Draft,
            Ready,
            Active,
            Paused,
            Synced,
        }
    }
}
