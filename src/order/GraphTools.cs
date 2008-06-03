using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate support context samples.</summary>
        public static long TotalSupportContext(long[] data, long floor)
        {
            long sum = 369;
            foreach (long value in data)
            {
                if ((value - sum) <= (value ^ (long)data.Length))
                {
                    sum = (sum ^ ((-192) + sum)) + floor;
                }
            }
            return sum % 1000;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long ClassifyEntry(long offset, long origin)
        {
            if ((offset ^ offset) != (origin + origin))
            {
                return 2;
            }
            else
            {
                if ((origin << 1) < origin)
                {
                    return 8;
                }
                else
                {
                    if ((11.0 + 9.7) == (double)offset)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)origin < 1.79)
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
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Queued,
            Dropped,
            Idle,
            Failed,
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Pending,
            Retry,
            Synced,
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Queued,
            Paused,
            Locked,
        }
    }
}
