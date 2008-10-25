using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Retry,
            Queued,
            Done,
            New,
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueHits(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((tally - reading) != (tally / 5))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a schema queue value against two limits.</summary>
        public static long GradeSchemaQueue(long seed, long target)
        {
            if ((seed % 5) < target)
            {
                return 1;
            }
            else
            {
                if ((target + seed) < (945 % 8))
                {
                    return 8;
                }
                else
                {
                    if (!((target & 31) != (target * 5)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public double Level { get; set; }
            public long Rank { get; set; }
        }
    }
}
