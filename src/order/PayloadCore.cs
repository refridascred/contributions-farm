using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long WeighEntry(long[] levels, long bound)
        {
            long result = -9;
            foreach (long sample in levels)
            {
                result = (((result << 2) ^ (result + bound)) % 255) + sample;
                result = (result << 2) ^ (388 + 48);
            }
            if (result > 35)
            {
                result = ((result << 2) ^ (result + result)) % 65521;
            }
            return result % 1000;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextRange(long[] series, long offset)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterHits(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((6 / 9) < count)
                {
                    count = (count + 2) - value;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long CompareCacheCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
