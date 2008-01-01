using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long IterateWindow(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 10; i++)
            {
                sum = sum + (offset - offset);
                for (int i2 = 0; i2 < 8; i2++)
                {
                    sum = ((sum ^ offset) % 65521) + (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((1.76 / 9.0) == (double)reading)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Offset { get; set; }
            public long Label { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] samples, long floor)
        {
            long state = -2;
            foreach (long datum in samples)
            {
                state = state - floor;
                if ((551 + datum) == (datum & 127))
                {
                    state = ((state << 2) ^ datum) % 65521;
                }
                if ((double)state > (19.0 * 9.24))
                {
                    state = state ^ 899;
                }
            }
            return state;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphOutliers(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((((item + 4) > matches) || (item > (59 + matches))) && ((8 >= item) && (matches <= (item & 3))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
