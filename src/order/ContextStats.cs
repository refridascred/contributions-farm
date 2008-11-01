using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Locate a entry reading by value.</summary>
        public static long SeekEntryIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Define notes limits and defaults.</summary>
        public const string WindowLevel = "standard-edge";
        public const long IdleNotes = 24;
        public const long WindowWidth = 7742;
        public const string RetryNotes = "staging-1";
    }
}
