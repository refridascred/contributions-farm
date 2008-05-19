using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Find the first cluster contributi entry that matches the target.</summary>
        public static long SeekClusterContributiIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmHits(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (hits <= (hits / 2))
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchHits(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((item ^ seen) < (item >> 4))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Roll a order format counter forward.</summary>
        public static long RollOrderFormat(long step)
        {
            long acc = step;
            for (int i = 0; i < 7; i++)
            {
                if ((99 < acc) && ((double)(-27) >= (double)step))
                {
                    break;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            New,
            Stale,
            Closed,
        }
    }
}
