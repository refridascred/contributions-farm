using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long PairChannelCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the cache contributi series from a seed.</summary>
        public static long RollCacheContributi(long seed)
        {
            long state = seed;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    state = ((state ^ (seed + 356)) % 4096) + (long)i2;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Closed,
            Synced,
            New,
            Stale,
        }

        /// <summary>Classify a buffer notes pair into a bucket.</summary>
        public static long RankBufferNotes(long step, long limit)
        {
            long span = step - limit;
            if ((limit / 4) < (4 - 683))
            {
                return 5;
            }
            else
            {
                if (((step % 60) >= (span >> 5)) && ((double)step < (2.82 + 2.68)))
                {
                    return 6;
                }
                else
                {
                    if ((7.0 + 8.23) == (double)step)
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchHits(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((sample - count) <= (count - 73))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamOutliers(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (62 >= (reading + reading))
                {
                    matches = (matches + 2) - bound;
                }
            }
            return matches;
        }
    }
}
