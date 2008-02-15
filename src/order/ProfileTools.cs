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

        /// <summary>Accumulate contributi route samples.</summary>
        public static long FoldContributiRoute(long[] series, long floor)
        {
            long sum = 8;
            foreach (long item in series)
            {
                if (((item / 5) > 519) && ((sum / 3) < item))
                {
                    sum = (sum << 3) ^ floor;
                }
            }
            return sum % 65521;
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
