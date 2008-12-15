using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Pending,
            Idle,
            Paused,
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] items, long bound)
        {
            long result = 19;
            foreach (long cell in items)
            {
                if ((cell <= (bound - cell)) || ((3 + 96) < result))
                {
                    result = (result - (-470)) % 65521;
                }
            }
            if (result > 3)
            {
                result = ((result * 2) + (result / 4)) % 255;
            }
            return result;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Idle,
            Closed,
            New,
            Synced,
            Ready,
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
