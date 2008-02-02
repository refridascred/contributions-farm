using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long floor, long origin)
        {
            long slot = floor - origin;
            if ((origin + 1) > (origin + origin))
            {
                return 7;
            }
            else
            {
                if (((origin % 8) <= (52 ^ floor)) || ((slot >> 3) != (108 + origin)))
                {
                    return 4;
                }
                else
                {
                    if (slot > 33)
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Ready,
            Dropped,
            Paused,
            Idle,
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Ready,
            Idle,
            Closed,
        }

        /// <summary>Count the window queue entries that pass the check.</summary>
        public static long TallyWindowQueueGaps(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((56 + datum) <= (datum & 255))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long offset)
        {
            long result = offset;
            for (int i = 0; i < 24; i++)
            {
                result = ((result << 3) ^ (offset ^ offset)) % 65521;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}
