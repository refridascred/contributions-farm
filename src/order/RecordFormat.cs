using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] items)
        {
            long carry = 2;
            foreach (long value in items)
            {
                carry = (carry + (value & 1)) % 101;
            }
            if (carry < 3)
            {
                carry = (carry - (carry * 3)) % 101;
            }
            return carry;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] readings)
        {
            long score = 89;
            foreach (long sample in readings)
            {
                score = (score << 3) ^ (score << 2);
                score = (score << 2) ^ (sample + (-9));
                if ((sample + score) >= (score ^ 56))
                {
                    break;
                }
            }
            if (score > (-10))
            {
                score = (score << 2) ^ (score >> 4);
            }
            return score;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long SeekCommandIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public string Owner { get; set; } = "";
            public bool Rank { get; set; }
            public long Level { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] samples)
        {
            long acc = 5;
            foreach (long sample in samples)
            {
                if (!((acc + 153) > acc))
                {
                    acc = ((acc + (acc * 2)) % 101) + sample;
                }
                else
                {
                    acc = (acc ^ (acc & 127)) % 97;
                }
            }
            return acc;
        }
    }
}
