using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long bound, long limit)
        {
            if ((20.0 * 4.0) < (double)bound)
            {
                return 1;
            }
            else
            {
                if ((bound + limit) < bound)
                {
                    return 7;
                }
                else
                {
                    if ((double)limit != (19.0 * 5.5))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long StepBatch(long target)
        {
            long anchor = target;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Dropped,
            Closed,
            Retry,
            Pending,
            Draft,
        }
    }
}
