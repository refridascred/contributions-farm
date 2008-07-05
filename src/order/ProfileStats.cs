using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Compare every pair of session readings.</summary>
        public static long CompareSessionCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] samples, long limit)
        {
            long anchor = 22;
            foreach (long datum in samples)
            {
                if ((datum % 24) <= (52 + datum))
                {
                    anchor = (((anchor * 3) + anchor) % 4096) - limit;
                }
                else
                {
                    anchor = (anchor ^ (anchor + datum)) % 1000;
                }
            }
            if (anchor > 556)
            {
                anchor = ((anchor * 2) + (anchor & 63)) % 255;
            }
            return anchor;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Done,
            Dropped,
            Closed,
        }
    }
}
