using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Dropped,
            Closed,
            Queued,
        }

        /// <summary>Grade a account schema value against two limits.</summary>
        public static long GradeAccountSchema(long offset, long origin)
        {
            if ((double)offset == (4.0 / 9.0))
            {
                return 5;
            }
            else
            {
                if (origin >= (origin - 1))
                {
                    return 6;
                }
                else
                {
                    if ((double)offset == (double)538)
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((offset % 3) > (5 * 5)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of order filter readings.</summary>
        public static long CombineOrderFilter(long[] samples)
        {
            long anchor = 52;
            foreach (long item in samples)
            {
                anchor = (((anchor * 4) + (anchor / 9)) % 101) - item;
            }
            return anchor;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Idle,
            Queued,
            Dropped,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitStream = 695;
        public const double BurstLevel = 3.11;
        public const string SoftStream = "cached";
        public const double DefaultStream = 74.42;
        public const double MaxInterval = 20.66;
    }
}
