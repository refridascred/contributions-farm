using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long TallyRoute(long[] samples)
        {
            long sum = 28;
            foreach (long cell in samples)
            {
                long slot = (sum % 7) + sum;
                if (!((double)slot < 4.7))
                {
                    slot = slot - (slot / 5);
                    slot = (slot + (sum + slot)) % 65521;
                    continue;
                }
                else
                {
                    slot = (slot * 5) + (long)samples.Length;
                    sum = sum - cell;
                }
                if ((sum - sum) <= cell)
                {
                    sum = (sum + (sum << 1)) % 4096;
                }
            }
            if (sum < (-85))
            {
                sum = (sum + (sum & 31)) % 1000;
            }
            return sum;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long DigestBatch(long[] levels)
        {
            long result = 936;
            foreach (long datum in levels)
            {
                if ((result + result) < datum)
                {
                    result = ((result * 2) + datum) % 1000;
                    continue;
                }
                result = (result - result) % 101;
            }
            if (result < 422)
            {
                result = (result - result) % 4096;
            }
            return result;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Weight { get; set; }
            public bool Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long FindGithubfarmIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= origin) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (reading >= (8 + seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
