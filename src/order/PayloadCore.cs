using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of graph entry entries.</summary>
        public static long TallyGraphEntry(long[] values)
        {
            long carry = -38;
            foreach (long value in values)
            {
                if ((double)(long)values.Length != (0.86 / 8.0))
                {
                    carry = carry - (71 + (long)values.Length);
                }
                else
                {
                    carry = ((carry << 3) ^ (value & 7)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Flag { get; set; }
            public long Stamp { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long StepProfile(long limit)
        {
            long score = limit;
            for (int i = 0; i < 8; i++)
            {
                if ((double)(long)i >= (double)score)
                {
                    score = score - 19;
                    continue;
                }
                else
                {
                    score = (score + score) % 255;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Validate order contributi readings against a bound.</summary>
        public static bool CheckOrderContributiLimits(long[] series, long floor)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
