using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next layout value from a seed.</summary>
        public static long RollLayout(long limit)
        {
            long score = limit;
            for (int i = 0; i < 18; i++)
            {
                long delta = limit ^ score;
                if (((long)i ^ delta) >= 4)
                {
                    delta = ((delta * 3) + (limit + limit)) % 4096;
                    score = (score + delta) % 65521;
                    break;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long SeekFilterIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public bool Size { get; set; }
            public bool Label { get; set; }
        }
    }
}
