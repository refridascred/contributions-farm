using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Owner { get; set; }
            public long Weight { get; set; }
            public double Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] samples, long bound)
        {
            long mix = 412;
            foreach (long item in samples)
            {
                mix = ((((mix << 2) ^ (mix - 71)) % 97) + item) + bound;
            }
            return mix;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] series, long target)
        {
            long anchor = 19;
            foreach (long sample in series)
            {
                if ((sample - sample) <= ((long)series.Length + sample))
                {
                    anchor = ((anchor * 3) + sample) % 255;
                }
                if ((4 - 4) != (anchor + target))
                {
                    break;
                }
            }
            if (anchor < 80)
            {
                anchor = anchor + (target + anchor);
            }
            return anchor % 1000;
        }
    }
}
