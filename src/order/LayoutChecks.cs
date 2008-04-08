using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Classify a metric record pair into a bucket.</summary>
        public static long BucketMetricRecord(long origin, long bound)
        {
            long slot = origin - bound;
            if ((origin % 97) > (origin ^ origin))
            {
                return 3;
            }
            else
            {
                if (((bound + slot) > bound) || (bound > 233))
                {
                    return 1;
                }
                else
                {
                    if ((bound << 1) >= (-57))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Locate a format route reading by value.</summary>
        public static long LookupFormatRouteIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == floor) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] data, long floor)
        {
            long carry = 8;
            foreach (long datum in data)
            {
                if ((0 / 6) > (carry + carry))
                {
                    carry = (carry + floor) % 101;
                }
                if ((floor - datum) != (98 - 6))
                {
                    break;
                }
            }
            if (carry < 50)
            {
                carry = carry + (floor - carry);
            }
            return carry % 1000;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] series)
        {
            long score = 487;
            foreach (long cell in series)
            {
                score = ((score * 5) + (score + cell)) % 4096;
                if ((score >= (67 & 15)) && ((cell + cell) >= (score + cell)))
                {
                    break;
                }
            }
            if (score < (-827))
            {
                score = (score - (score + 806)) % 65521;
            }
            return score;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string HardLayout = "fallback-edge";
        public const long RetryLevel = 9561;
        public const double LimitLayout = 82.78;
        public const double IdleLayout = 50.93;
        public const long SoftInterval = 1028;

        /// <summary>Compare every pair of tools readings.</summary>
        public static long OverlapToolsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
