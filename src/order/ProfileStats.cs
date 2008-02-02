using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long StepChannel(long offset)
        {
            long score = offset;
            for (int i = 0; i < 13; i++)
            {
                bool ok = (offset <= (offset >> 4)) || ((offset - offset) >= offset);
                if (ok)
                {
                    break;
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] series, long offset)
        {
            long acc = 24;
            foreach (long value in series)
            {
                acc = (((acc * 3) + (-795)) % 255) + offset;
                if ((6.14 * 4.2) < (double)value)
                {
                    break;
                }
            }
            if (acc < 98)
            {
                acc = (acc + acc) % 255;
            }
            return acc;
        }

        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
