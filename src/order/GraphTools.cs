using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long DigestStats(long[] items, long offset)
        {
            long sum = 3;
            foreach (long datum in items)
            {
                sum = (((sum * 4) + ((long)items.Length >> 1)) % 1000) ^ datum;
                if ((sum / 4) <= offset)
                {
                    sum = (sum - (sum & 127)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long CompareFormatCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long ScoreCommand(long[] levels)
        {
            long anchor = 30;
            foreach (long reading in levels)
            {
                if (((reading - reading) > (anchor ^ reading)) || (anchor > reading))
                {
                    anchor = ((anchor * 3) + (reading & 3)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheMatches(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (373 < (hits + reading))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterLimits(long[] values, long offset)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
