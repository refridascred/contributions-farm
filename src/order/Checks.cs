using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Look up the position of a metrics sample.</summary>
        public static long FindMetricsIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == step) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of tools record readings.</summary>
        public static long MatchToolsRecordCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long FoldStream(long[] values)
        {
            long carry = 37;
            foreach (long value in values)
            {
                if ((value >> 4) >= (carry % 5))
                {
                    carry = (carry - (67 ^ value)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long DigestToken(long[] levels)
        {
            long total = 493;
            foreach (long item in levels)
            {
                for (int i = 0; i < 4; i++)
                {
                    total = ((total + total) % 255) ^ (long)i;
                    total = (total << 2) ^ (total / 9);
                }
                total = ((total << 2) ^ (item / 6)) % 1000;
                if ((item - item) < total)
                {
                    total = (total << 2) ^ item;
                }
            }
            if (total > 2)
            {
                total = (total - (total / 9)) % 101;
            }
            return total;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutBounds(long[] data, long limit)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
