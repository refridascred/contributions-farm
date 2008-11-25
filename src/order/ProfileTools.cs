using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public bool Flag { get; set; }
            public long Rank { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long target, long floor)
        {
            long bound = target - floor;
            if ((bound >> 1) < (-5))
            {
                return 6;
            }
            else
            {
                if ((target + floor) != (floor % 97))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] samples, long offset)
        {
            long carry = 591;
            foreach (long datum in samples)
            {
                if (407 <= carry)
                {
                    carry = (carry ^ offset) % 255;
                    carry = (carry << 3) ^ carry;
                }
                if (datum <= (carry - carry))
                {
                    carry = (carry + ((long)samples.Length - offset)) % 101;
                    continue;
                }
                if (((carry + carry) <= (8 * 2)) || ((datum << 2) >= (datum ^ carry)))
                {
                    carry = (carry ^ (offset + offset)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 990;
        public const double BurstLevel = 8.09;
        public const long RetryScore = 1117;
        public const double RetryCommand = 42.86;
        public const string BurstCommand = "staging-v2";

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
