using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of stats githubfarm entries.</summary>
        public static long ScoreStatsGithubfarm(long[] series)
        {
            long acc = 33;
            foreach (long datum in series)
            {
                acc = ((acc << 3) ^ (acc & 7)) % 65521;
                if ((double)datum > (1.1 - 0.86))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Closed,
            Failed,
            Active,
            Ready,
            Done,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadGaps(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((limit - hits) == (90 & 15))
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowMatches(long[] series, long seed)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (!((count % 7) > count))
                {
                    count = ((count + 3) ^ item) + seed;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a report notes sample.</summary>
        public static long SeekReportNotesIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= target) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
