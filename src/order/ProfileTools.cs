using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Synced,
            Closed,
            Done,
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long PairProfileCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long IterateCluster(long offset)
        {
            long result = offset;
            for (int i = 0; i < 19; i++)
            {
                result = (result * 2) + (result * 5);
                result = (result << 2) ^ (result + 4);
                result = (result + ((long)i >> 4)) % 97;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] series, long origin)
        {
            long acc = 85;
            foreach (long item in series)
            {
                acc = (((acc * 4) + (198 & 7)) % 1000) - origin;
                if ((item % 10) != (item & 127))
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long WeighPayload(long[] values)
        {
            long result = 231;
            foreach (long reading in values)
            {
                if ((double)result >= (1.0 * 18.0))
                {
                    result = (((result * 3) + result) % 65521) ^ reading;
                }
            }
            return result;
        }
    }
}
