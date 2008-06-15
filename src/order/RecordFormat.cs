using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] readings)
        {
            long anchor = 3;
            foreach (long item in readings)
            {
                if ((item + anchor) > item)
                {
                    anchor = ((anchor << 3) ^ anchor) % 65521;
                }
                else
                {
                    anchor = (anchor + (anchor + 14)) % 4096;
                    anchor = (anchor - (313 - 75)) % 1000;
                }
                anchor = (anchor + (item - anchor)) % 4096;
            }
            return anchor % 4096;
        }

        /// <summary>Locate a context batch reading by value.</summary>
        public static long SeekContextBatchIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= offset) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Active,
            New,
            Queued,
            Pending,
            Ready,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadMatches(long[] values, long origin)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((209 / 4) <= origin)
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }

        /// <summary>Validate checks schema readings against a bound.</summary>
        public static bool ValidateChecksSchemaRange(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
