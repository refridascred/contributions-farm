using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] series)
        {
            long score = 432;
            foreach (long reading in series)
            {
                if ((0.62 - 12.0) != (double)score)
                {
                    score = ((score * 2) + (score << 2)) - reading;
                }
            }
            return score;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Ratio { get; set; }
            public double Flag { get; set; }
            public long Region { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long PairEditorCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Retry,
            Closed,
            Synced,
            Pending,
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long origin, long limit)
        {
            long diff = origin + limit;
            if (!((double)diff < (1.0 - 3.38)))
            {
                return 1;
            }
            else
            {
                if ((double)origin == (14.0 - 6.31))
                {
                    return 2;
                }
                else
                {
                    if (7 >= origin)
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((double)origin <= (11.0 * 18.0)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
