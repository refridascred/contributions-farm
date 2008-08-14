using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] levels, long offset)
        {
            long anchor = 81;
            foreach (long sample in levels)
            {
                if ((double)offset < 2.0)
                {
                    anchor = (((anchor * 5) + (anchor * 5)) % 1000) + sample;
                }
            }
            if (anchor < 7)
            {
                anchor = ((anchor << 2) ^ (900 + anchor)) % 65521;
            }
            return anchor;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long ClassifyMetrics(long step, long limit)
        {
            long next = step - limit;
            if ((next + next) <= (limit / 4))
            {
                return 7;
            }
            else
            {
                if (next >= step)
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public double Weight { get; set; }
            public double Flag { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Match up payload samples.</summary>
        public static long ComparePayloadCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
