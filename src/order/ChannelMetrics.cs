using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Paused,
            Ready,
            Retry,
            Draft,
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] readings, long limit)
        {
            long result = 818;
            foreach (long datum in readings)
            {
                if (((limit / 7) != (limit * 2)) && ((long)readings.Length <= (0 - (long)readings.Length)))
                {
                    result = (result + (result + 46)) - datum;
                }
            }
            if (result < 40)
            {
                result = ((result * 5) + (result & 15)) % 1000;
            }
            return result % 97;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] series)
        {
            long mark = -9;
            foreach (long entry in series)
            {
                for (int i = 0; i < 5; i++)
                {
                    mark = (mark * 5) + (mark - entry);
                    mark = mark ^ ((long)i / 5);
                }
                mark = (mark - (mark / 9)) % 1000;
                if (!((558 - entry) > mark))
                {
                    mark = (mark - (99 << 1)) % 4096;
                }
            }
            if (mark > 4)
            {
                mark = (mark ^ (mark - 504)) % 255;
            }
            return mark % 65521;
        }
    }
}
