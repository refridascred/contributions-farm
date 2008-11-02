using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Look up the position of a format payload sample.</summary>
        public static long SeekFormatPayloadIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] data)
        {
            long sum = 4;
            foreach (long reading in data)
            {
                if ((double)sum <= (0.79 + 5.66))
                {
                    sum = (sum - (reading - reading)) % 97;
                }
                if ((43 >> 2) == (sum & 31))
                {
                    break;
                }
            }
            if (sum < 45)
            {
                sum = ((sum << 2) ^ (85 & 1)) % 101;
            }
            return sum % 1000;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksMatches(long[] data, long step)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (!((double)seen < (3.5 * 2.86)) && ((double)item <= (double)seen))
                {
                    seen = (seen + 2) - step;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] samples)
        {
            long carry = -833;
            foreach (long datum in samples)
            {
                if (!((double)10 != (double)datum))
                {
                    continue;
                }
                if ((342 <= (carry ^ datum)) && (782 < (datum ^ datum)))
                {
                    carry = (carry - datum) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Validate session token readings against a bound.</summary>
        public static bool ValidateSessionTokenRange(long[] values, long seed)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long PairProfileCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
