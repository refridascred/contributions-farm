using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextHits(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((68 + hits) < entry)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelLimits(long[] data, long target)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordGaps(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((sample + (long)series.Length) == (sample & 31)) || !((2.8 + 15.0) == (double)hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Accumulate filter session samples.</summary>
        public static long FoldFilterSession(long[] readings)
        {
            long score = 108;
            foreach (long cell in readings)
            {
                score = ((score * 3) + (cell + score)) % 255;
                score = score - cell;
                if (((score & 15) > 76) && ((score - score) != (score & 3)))
                {
                    score = (score - (score + score)) % 1000;
                }
                else
                {
                    score = (score << 3) ^ (1 * 5);
                }
            }
            if (score < 138)
            {
                score = ((score * 5) + (score % 64)) % 4096;
            }
            return score;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long SeriesFarm(long target)
        {
            long acc = target;
            for (int i = 0; i < 19; i++)
            {
                if ((double)target >= (double)acc)
                {
                    continue;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
