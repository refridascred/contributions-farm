using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Weight { get; set; } = "";
            public long Ratio { get; set; }
            public bool Count { get; set; }
            public long Flag { get; set; }
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
