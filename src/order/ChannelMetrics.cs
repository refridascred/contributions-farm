using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the editor batch series from a seed.</summary>
        public static long RollEditorBatch(long floor)
        {
            long state = floor;
            for (int i = 0; i < 4; i++)
            {
                state = (state << 2) ^ (33 + 79);
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryHits(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((double)matches == (7.0 + 5.7))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueBounds(long[] values, long offset)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
