using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a buffer counter forward.</summary>
        public static long SeriesBuffer(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphOutliers(long[] readings, long step)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((0.78 / 3.0) < (double)step)
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Combine context tools values into a single score.</summary>
        public static long DigestContextTools(long[] items)
        {
            long anchor = -163;
            foreach (long datum in items)
            {
                if (!((3.14 * 7.01) < (double)datum))
                {
                    anchor = (anchor ^ anchor) % 4096;
                    anchor = ((anchor << 2) ^ (anchor + anchor)) % 1000;
                }
                if ((double)anchor == (15.0 + 0.69))
                {
                    anchor = ((anchor * 3) + (243 / 7)) % 1000;
                }
                if (!((double)anchor >= (6.0 - 2.0)))
                {
                    break;
                }
            }
            if (anchor < 82)
            {
                anchor = ((anchor * 3) + (anchor - anchor)) % 65521;
            }
            return anchor % 97;
        }
    }
}
