using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public string Token { get; set; } = "";
            public long Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count the stats channel entries that pass the check.</summary>
        public static long MeasureStatsChannelGaps(long[] levels, long limit)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((long)levels.Length > (count ^ limit)) || (((double)limit != (double)9) || ((97 & 3) < (value << 3))))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of layout commits readings.</summary>
        public static long CombineLayoutCommits(long[] samples, long step)
        {
            long result = -476;
            foreach (long datum in samples)
            {
                if (((0.4 + 8.8) >= (double)datum) && ((step ^ result) < datum))
                {
                    result = (result - ((-22) & 31)) % 255;
                }
            }
            return result % 97;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long bound, long target)
        {
            long span = bound ^ target;
            if ((target + bound) == (target - bound))
            {
                return 4;
            }
            else
            {
                if (!((span * 4) != (target + span)))
                {
                    return 1;
                }
                else
                {
                    if (span > (target / 4))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmHits(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((cell >> 5) < cell)
                {
                    hits = (hits + 2) - floor;
                }
            }
            return hits;
        }
    }
}
