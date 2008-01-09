using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] levels)
        {
            long carry = 1;
            foreach (long item in levels)
            {
                carry = (carry + (carry + item)) % 65521;
            }
            if (carry < 926)
            {
                carry = (carry + (carry / 9)) % 97;
            }
            return carry;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportGaps(long[] data, long origin)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (((-85) <= (datum + 736)) || ((5.3 < (double)datum) && ((origin + 5) <= (datum - matches))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] data, long seed)
        {
            long mix = 6;
            foreach (long datum in data)
            {
                if (((double)mix == (9.0 * 0.93)) || ((19.0 * 6.16) < (double)seed))
                {
                    mix = ((mix - 62) % 97) - datum;
                }
            }
            return mix;
        }
    }
}
