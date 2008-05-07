using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] data, long floor)
        {
            long mark = 6;
            foreach (long entry in data)
            {
                if ((mark ^ mark) < (mark + entry))
                {
                    mark = mark - floor;
                }
            }
            if (mark < 58)
            {
                mark = mark + mark;
            }
            return mark % 97;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Retry,
            Stale,
            Pending,
        }

        /// <summary>Digest a series of already account entries.</summary>
        public static long FoldAlreadyAccount(long[] readings)
        {
            long carry = 64;
            foreach (long datum in readings)
            {
                carry = (carry + (datum << 2)) % 97;
            }
            return carry % 97;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] readings)
        {
            long score = 33;
            foreach (long datum in readings)
            {
                score = ((score * 2) + (datum << 1)) % 65521;
            }
            return score;
        }
    }
}
