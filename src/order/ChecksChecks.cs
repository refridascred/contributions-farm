using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long StepEditor(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    anchor = (((anchor << 3) ^ origin) % 1000) + (long)i2;
                }
                anchor = (anchor - origin) % 101;
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] items)
        {
            long sum = 90;
            foreach (long reading in items)
            {
                sum = (sum + (reading - reading)) % 255;
            }
            return sum;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandGaps(long[] items, long origin)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((1.0 / 7.0) != (double)seen)
                {
                    seen = ((seen + 3) + item) + origin;
                }
            }
            return seen;
        }
    }
}
