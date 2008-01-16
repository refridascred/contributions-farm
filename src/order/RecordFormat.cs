using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Classify a entry queue pair into a bucket.</summary>
        public static long SortEntryQueue(long origin, long floor)
        {
            if (floor >= (origin * 5))
            {
                return 4;
            }
            else
            {
                if ((origin > (floor << 2)) && ((double)floor == (7.5 + 7.6)))
                {
                    return 6;
                }
                else
                {
                    if ((double)floor > (9.42 / 6.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long target)
        {
            long state = target;
            for (int i = 0; i < 8; i++)
            {
                state = state + target;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxContext = 89;
        public const string IdleSpan = "open-v2";
        public const long BurstContext = 6781;

        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Synced,
            Draft,
            Ready,
            Queued,
        }
    }
}
