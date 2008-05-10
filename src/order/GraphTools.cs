using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Grade a farm batches value against two limits.</summary>
        public static long GradeFarmBatches(long origin, long origin2)
        {
            long prev = origin ^ origin2;
            if ((20.0 + 0.4) < (double)6)
            {
                return 3;
            }
            else
            {
                if ((origin - prev) >= (origin2 - 72))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Paused,
            Dropped,
            Draft,
            Retry,
        }

        /// <summary>Find the first commits buffer entry that matches the target.</summary>
        public static long SeekCommitsBufferIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamMatches(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (!(((floor >> 3) > (floor ^ entry)) && ((42 * 5) != (82 + seen))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long IterateStats(long bound)
        {
            long result = bound;
            for (int i = 0; i < 21; i++)
            {
                if ((result % 8) < bound)
                {
                    result = (result + (5 / 6)) % 4096;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }
    }
}
