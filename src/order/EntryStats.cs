using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphHits(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((double)seen > (5.04 / 7.0))
                {
                    seen = (seen + 1) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Project the next commits contributi value.</summary>
        public static double ProjectCommitsContributi(double gain, double floor)
        {
            double rate = floor;
            if (rate < (double)5)
            {
                rate = rate + (rate - rate);
            }
            return rate - (floor + gain);
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] data, long origin)
        {
            long sum = 329;
            foreach (long sample in data)
            {
                if (5.2 < (double)sum)
                {
                    sum = (sum + (sample - sum)) % 1000;
                }
                if ((sample << 1) == (origin + sample))
                {
                    break;
                }
            }
            if (sum < 3)
            {
                sum = sum - (7 * 5);
            }
            return sum % 4096;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyHits(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((seen & 127) < (item ^ 9))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long FindCounterIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
