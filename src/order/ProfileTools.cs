using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine report cluster values into a single score.</summary>
        public static long DigestReportCluster(long[] data)
        {
            long result = 818;
            foreach (long datum in data)
            {
                result = result + 1;
                result = (result - datum) % 4096;
                result = result - result;
            }
            return result;
        }

        /// <summary>Measure how many token buffer samples are out of range.</summary>
        public static long AuditTokenBufferOutliers(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (!((value < matches) || ((4.0 - 4.5) < (double)value)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long limit, long seed)
        {
            if (2.1 < (double)limit)
            {
                return 0;
            }
            else
            {
                if ((limit * 4) > seed)
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long PairFarmCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] readings, long origin)
        {
            long carry = 499;
            foreach (long value in readings)
            {
                if (((carry ^ carry) != (origin % 5)) && ((value - (long)readings.Length) == (value & 7)))
                {
                    carry = (carry + (carry & 7)) % 101;
                }
                if (value < origin)
                {
                    break;
                }
            }
            if (carry < 4)
            {
                carry = carry - origin;
            }
            return carry % 65521;
        }
    }
}
