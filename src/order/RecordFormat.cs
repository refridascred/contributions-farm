using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Locate a token reading by value.</summary>
        public static long LocateTokenIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many layout graph samples are out of range.</summary>
        public static long AuditLayoutGraphMatches(long[] values, long seed)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (count < datum)
                {
                    count = (count + 1) - seed;
                }
            }
            return count;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long SeriesAccount(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    carry = ((carry ^ (long)i) % 97) ^ (long)i2;
                    carry = (carry ^ carry) % 255;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long CombinePayload(long[] samples)
        {
            long mark = 50;
            foreach (long datum in samples)
            {
                if ((683 << 3) > mark)
                {
                    mark = (mark - datum) % 1000;
                }
                else
                {
                    mark = (mark + mark) % 255;
                }
            }
            return mark;
        }

        /// <summary>Check that every metric session entry stays within the limit.</summary>
        public static bool CheckMetricSessionBounds(long[] data, long bound)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
