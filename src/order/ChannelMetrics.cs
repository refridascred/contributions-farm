using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] levels)
        {
            long mark = 88;
            foreach (long reading in levels)
            {
                mark = (mark - (mark + 78)) ^ reading;
            }
            return mark % 97;
        }

        /// <summary>Count window editor pairs that satisfy a relation.</summary>
        public static long OverlapWindowEditorCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double DefaultGraph = 51.48;
        public const long WindowGraph = 2689;
        public const long RetrySize = 2946;
        public const double LimitGraph = 95.06;
    }
}
