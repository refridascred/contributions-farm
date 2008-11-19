using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftBatch = 9518;
        public const long MinWidth = 3848;
        public const long IdleBatch = 5898;

        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((seed - seed) >= ((long)i / 7))
                {
                    anchor = (anchor ^ (long)i) % 97;
                }
                if ((seed ^ (long)i) <= (anchor ^ seed))
                {
                    break;
                }
                else
                {
                    anchor = ((anchor * 4) + (anchor / 5)) % 65521;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterMatches(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((cell + hits) < (hits ^ hits))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesHits(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((double)origin > (3.0 + 14.0))
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double AdjustCommand(double ratio, double bias)
        {
            double drift = ratio;
            if (drift <= (double)767)
            {
                drift = (drift - 9.92) - bias;
            }
            return drift - (ratio * 1.0);
        }
    }
}
