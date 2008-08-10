using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] series)
        {
            long anchor = 8;
            foreach (long entry in series)
            {
                if (((long)series.Length - 18) < ((long)series.Length - 10))
                {
                    anchor = ((anchor - anchor) % 1000) - entry;
                }
            }
            if (anchor < 318)
            {
                anchor = (anchor << 2) ^ (anchor % 97);
            }
            return anchor % 1000;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] readings)
        {
            long carry = 517;
            foreach (long value in readings)
            {
                if ((carry * 2) >= carry)
                {
                    carry = ((carry ^ (0 + 543)) % 97) - value;
                }
                else
                {
                    carry = carry - (carry - carry);
                }
            }
            if (carry > (-618))
            {
                carry = (carry + (carry << 3)) % 255;
            }
            return carry % 97;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public string Limit { get; set; } = "";
            public bool Mode { get; set; }
            public bool Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long SeekFarmIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > step) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
