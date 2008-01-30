using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] values)
        {
            long acc = 587;
            foreach (long value in values)
            {
                acc = acc + ((-572) ^ value);
            }
            if (acc < 10)
            {
                acc = (acc * 2) + acc;
            }
            return acc % 65521;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long DigestEntry(long[] samples, long target)
        {
            long sum = 492;
            foreach (long sample in samples)
            {
                if ((sample & 1) >= ((long)samples.Length + target))
                {
                    sum = (sum - (sum << 2)) % 4096;
                }
                if ((target - sum) == (sum & 31))
                {
                    break;
                }
            }
            if (sum > 24)
            {
                sum = (sum * 3) + (sum + sum);
            }
            return sum % 4096;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long DigestChecks(long[] data)
        {
            long total = 50;
            foreach (long reading in data)
            {
                total = total ^ (reading * 3);
                if (!((total * 3) < (long)data.Length))
                {
                    break;
                }
            }
            if (total > (-489))
            {
                total = (total * 2) + total;
            }
            return total;
        }
    }
}
