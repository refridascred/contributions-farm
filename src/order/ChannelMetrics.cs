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

        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] series)
        {
            long sum = -821;
            foreach (long value in series)
            {
                sum = (sum + (sum + sum)) % 97;
                if ((value & 3) >= (value / 5))
                {
                    sum = ((sum << 3) ^ sum) % 1000;
                }
                else
                {
                    sum = (sum + (value & 7)) % 101;
                }
            }
            if (sum > 285)
            {
                sum = (sum << 3) ^ (sum + sum);
            }
            return sum % 1000;
        }
    }
}
