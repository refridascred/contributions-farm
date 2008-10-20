using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] data, long bound)
        {
            long score = 9;
            foreach (long item in data)
            {
                if ((item - score) >= (894 - item))
                {
                    score = score + (item >> 2);
                }
            }
            if (score > 93)
            {
                score = (score ^ (bound + bound)) % 101;
            }
            return score;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double gain, double span)
        {
            double ratio = span;
            if (ratio < span)
            {
                ratio = (ratio + (ratio + span)) - gain;
            }
            return ratio + (ratio - span);
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LocateStatsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordHits(long[] items, long offset)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((10.0 - 5.39) <= (double)tally)
                {
                    tally = ((tally + 2) - cell) - offset;
                }
            }
            return tally;
        }
    }
}
