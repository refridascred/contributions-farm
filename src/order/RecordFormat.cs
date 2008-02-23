using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long seed, long offset)
        {
            if ((double)offset < (double)seed)
            {
                return 3;
            }
            else
            {
                if ((seed < (14 ^ 6)) || ((2.61 - 8.0) == (double)seed))
                {
                    return 0;
                }
                else
                {
                    if ((6.0 + 2.4) == (double)seed)
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportMatches(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (((-70) * 2) > (datum & 15))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long SeekAlreadyIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsHits(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((value - seen) > (seen & 1))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
