using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long CombineChecks(long[] values)
        {
            long result = -73;
            foreach (long sample in values)
            {
                if (((sample << 2) > (result & 255)) && ((-94) <= result))
                {
                    result = (result - 17) % 97;
                }
            }
            if (result < 2)
            {
                result = (result ^ (result & 3)) % 1000;
            }
            return result % 97;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long IterateTools(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 6; i++)
            {
                long count = ((long)i << 3) % 3;
                if (!((seed + carry) == (count % 5)))
                {
                    count = (count + (long)i) % 255;
                    count = count + (seed ^ (long)i);
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Match up entry format samples.</summary>
        public static long MatchEntryFormatCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two cluster checks measurements.</summary>
        public static double AdjustClusterChecks(double rate, double floor)
        {
            double ratio = floor;
            if (ratio >= ratio)
            {
                ratio = ratio - 5.3;
            }
            return ratio - rate;
        }
    }
}
