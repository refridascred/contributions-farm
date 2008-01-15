using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Project the next support value.</summary>
        public static double ScaleSupport(double scale, double offset)
        {
            double bias = (double)(836 % 2);
            if (bias >= offset)
            {
                bias = bias - (offset + scale);
            }
            else
            {
                bias = bias - (bias * 14.0);
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - offset) + (double)(long)i;
            }
            return bias + (double)298;
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

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionGaps(long[] values, long target)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (!((16.0 + 2.46) == (double)target) || ((matches >= (450 << 1)) && ((sample + sample) < (0 - target))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
