using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public bool Region { get; set; }
            public long Size { get; set; }
            public string Owner { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double LimitCluster = 63.17;
        public const string MaxCluster = "standard-1";
        public const double WindowFactor = 44.95;

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long CompareCounterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksHits(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (seen < item)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long target, long origin)
        {
            if ((double)origin <= (double)142)
            {
                return 8;
            }
            else
            {
                if (origin < (90 - target))
                {
                    return 7;
                }
                else
                {
                    if ((origin + origin) != (target - target))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!(origin < ((-13) * 4)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
