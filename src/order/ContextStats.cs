using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandMatches(long[] levels, long step)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((seen ^ seen) <= (step + entry))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the filter batch series from a seed.</summary>
        public static long RollFilterBatch(long step)
        {
            long anchor = step;
            for (int i = 0; i < 6; i++)
            {
                anchor = anchor - step;
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long SeekClusterIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up editor contributi samples.</summary>
        public static long MatchEditorContributiCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
