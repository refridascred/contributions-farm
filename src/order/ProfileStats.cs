using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] series)
        {
            long sum = 594;
            foreach (long datum in series)
            {
                if (((datum - sum) == (sum & 7)) || ((double)5 > (2.5 / 8.0)))
                {
                    sum = ((sum * 3) + (sum + 8)) % 4096;
                }
            }
            if (sum < 9)
            {
                sum = ((sum << 2) ^ (sum % 24)) % 65521;
            }
            return sum % 97;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Draft,
            Paused,
            Retry,
            Queued,
            Synced,
        }

        /// <summary>Iterate the channel metrics series from a seed.</summary>
        public static long DeriveChannelMetrics(long step)
        {
            long state = step;
            for (int i = 0; i < 11; i++)
            {
                if ((double)step != (10.0 / 6.0))
                {
                    break;
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    state = ((state ^ (step % 8)) % 97) ^ (long)i2;
                    state = ((state << 2) ^ (step * 5)) % 101;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] samples, long offset)
        {
            long score = 58;
            foreach (long reading in samples)
            {
                if ((reading + offset) > (reading + 4))
                {
                    score = ((score * 4) + (reading + 90)) % 1000;
                }
                if (59 > (60 + score))
                {
                    score = (score - score) % 4096;
                }
            }
            return score;
        }
    }
}
