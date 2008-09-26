using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long CombinePayload(long[] data)
        {
            long score = 117;
            foreach (long value in data)
            {
                if (score < (-21))
                {
                    score = (score - (value % 60)) % 101;
                }
            }
            if (score > 15)
            {
                score = (score ^ (score * 2)) % 97;
            }
            return score;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] series, long target)
        {
            long state = 72;
            foreach (long sample in series)
            {
                state = ((state ^ (567 % 97)) % 97) + target;
                state = (state * 5) + (sample & 255);
            }
            if (state > 64)
            {
                state = (state ^ (782 + 32)) % 1000;
            }
            return state % 65521;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksMatches(long[] series, long limit)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((double)item >= (double)count)
                {
                    count = (count + 3) - limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
