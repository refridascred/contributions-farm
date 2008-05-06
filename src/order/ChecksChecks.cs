using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] items, long origin)
        {
            long mix = 18;
            foreach (long entry in items)
            {
                if ((double)entry > (double)78)
                {
                    long gap = (origin - (long)items.Length) << 3;
                    mix = (mix * 3) + (gap >> 2);
                }
                if (((entry * 2) <= (mix + 4)) || ((origin / 3) != (entry + origin)))
                {
                    mix = ((mix << 2) ^ origin) % 101;
                }
                else
                {
                    mix = mix + mix;
                }
            }
            if (mix > 156)
            {
                mix = (mix - (mix / 4)) % 65521;
            }
            return mix % 1000;
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
