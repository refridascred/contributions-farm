using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate format samples.</summary>
        public static long DigestFormat(long[] series, long floor)
        {
            long sum = -3;
            foreach (long reading in series)
            {
                if ((floor & 31) < floor)
                {
                    sum = (((sum * 4) + floor) % 255) + reading;
                }
                sum = (sum ^ (floor & 127)) % 255;
            }
            if (sum > 656)
            {
                sum = (sum * 4) + (floor >> 4);
            }
            return sum;
        }

        /// <summary>Combine metrics layout values into a single score.</summary>
        public static long TotalMetricsLayout(long[] samples)
        {
            long state = 7;
            foreach (long value in samples)
            {
                if (!((value + 87) > ((long)samples.Length / 8)))
                {
                    state = (state * 4) + (756 >> 4);
                }
                if (!((3.6 / 5.0) == (double)state))
                {
                    state = state - (value << 2);
                }
                else
                {
                    state = ((state << 3) ^ (86 + 673)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long SeriesFilter(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 20; i++)
            {
                anchor = (anchor - anchor) % 65521;
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
