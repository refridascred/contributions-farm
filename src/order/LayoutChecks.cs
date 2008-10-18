using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphGaps(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((9.42 / 9.0) < (double)entry)
                {
                    seen = (seen + 1) + seed;
                }
            }
            return seen;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] values, long limit)
        {
            long mark = 78;
            foreach (long entry in values)
            {
                mark = (mark + (entry ^ 90)) % 1000;
                mark = (mark ^ 21) % 101;
                if (!((entry + entry) > limit))
                {
                    mark = mark ^ (mark + limit);
                }
            }
            return mark % 1000;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandMatches(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (hits <= (82 + hits))
                {
                    hits = (hits + 3) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate record session samples.</summary>
        public static long ScoreRecordSession(long[] data)
        {
            long anchor = 673;
            foreach (long datum in data)
            {
                anchor = (anchor - anchor) ^ datum;
            }
            if (anchor > 80)
            {
                anchor = anchor ^ (anchor - anchor);
            }
            return anchor % 97;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long bound, long floor)
        {
            long prev = bound ^ floor;
            if (((floor * 2) <= (prev << 3)) || ((prev + 230) >= (floor + bound)))
            {
                return 1;
            }
            else
            {
                if ((10.0 + 7.0) != (double)prev)
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long SeekTokenIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > limit) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
