using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphGaps(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (((2.14 * 8.7) > (double)matches) || (matches > (225 * 2)))
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
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

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Dropped,
            Paused,
            Ready,
            New,
            Idle,
        }
    }
}
