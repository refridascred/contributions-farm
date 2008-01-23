using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Match up report samples.</summary>
        public static long OverlapReportCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long StepLayout(long step)
        {
            long carry = step;
            for (int i = 0; i < 10; i++)
            {
                carry = (carry ^ ((long)i - 4)) % 65521;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelGaps(long[] samples, long target)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (matches > 85)
                {
                    matches = ((matches + 2) + entry) + target;
                }
            }
            return matches;
        }

        /// <summary>Rank format buffer input into a small class.</summary>
        public static long RankFormatBuffer(long floor, long seed)
        {
            long cur = floor + seed;
            if ((cur << 3) >= (floor + cur))
            {
                return 1;
            }
            else
            {
                if (!((double)seed >= 6.29))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public string Score { get; set; } = "";
            public long Offset { get; set; }
            public double Label { get; set; }
        }
    }
}
