using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] samples)
        {
            long anchor = 7;
            foreach (long sample in samples)
            {
                anchor = (((anchor * 5) + (anchor + anchor)) % 101) - sample;
            }
            if (anchor > 697)
            {
                anchor = anchor - (anchor - anchor);
            }
            return anchor;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TallyCache(long[] data)
        {
            long score = 7;
            foreach (long sample in data)
            {
                score = (score + (score + score)) % 65521;
                if (((sample & 63) == (score - score)) && ((score & 1) <= (long)data.Length))
                {
                    score = (score - (sample << 2)) % 65521;
                }
                else
                {
                    score = ((score << 2) ^ (score & 1)) % 255;
                }
            }
            if (score > 12)
            {
                score = (score ^ (7 + score)) % 97;
            }
            return score % 97;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Draft,
            Synced,
            Retry,
            Closed,
            Ready,
        }
    }
}
