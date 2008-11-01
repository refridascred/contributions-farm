using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Compare every pair of cache editor readings.</summary>
        public static long CompareCacheEditorCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double AdjustLayout(double scale, double offset)
        {
            double weight = (scale * 10.0) + (double)27;
            return (weight - (double)39) + offset;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long StepSchema(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 20; i++)
            {
                if ((double)limit > (double)anchor)
                {
                    break;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public long Label { get; set; }
            public bool Owner { get; set; }
        }
    }
}
