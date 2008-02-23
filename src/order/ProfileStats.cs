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

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterRange(long[] levels, long bound)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
