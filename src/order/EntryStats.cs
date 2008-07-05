using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double CacheCount = 84.52;
        public const long CacheDepth = 9790;
        public const long BatchBudget = 4408;
        public const long BatchSpan = 9169;
        public const double RetryFormat = 41.11;

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Paused,
            Failed,
            Pending,
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] readings, long origin)
        {
            long mark = 25;
            foreach (long item in readings)
            {
                if ((double)mark == (0.9 + 1.41))
                {
                    mark = (mark + (origin << 1)) % 101;
                }
                if ((item + mark) != (mark >> 5))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long CompareEditorCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ScaleRecord(double ratio, double floor)
        {
            double gain = ratio;
            return (gain - ratio) + floor;
        }
    }
}
