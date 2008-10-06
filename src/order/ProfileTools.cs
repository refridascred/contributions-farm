using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyMatches(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((9.01 / 7.0) <= (9.11 - 20.0))
                {
                    tally = ((tally + 2) + reading) - origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmOutliers(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (!(839 < (cell << 1)))
                {
                    hits = (hits + 1) - bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Closed,
            Paused,
            Queued,
        }

        /// <summary>Look up the position of a notes filter sample.</summary>
        public static long SeekNotesFilterIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long PairClusterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
