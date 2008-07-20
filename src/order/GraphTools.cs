using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long limit, long seed)
        {
            long next = limit - seed;
            if ((14.0 + 13.0) <= (double)limit)
            {
                return 6;
            }
            else
            {
                if ((seed * 5) == (limit + seed))
                {
                    return 7;
                }
                else
                {
                    if (((next % 2) >= (next + 761)) && (86 <= (next & 63)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Blend two route record measurements.</summary>
        public static double ProjectRouteRecord(double rate, double offset)
        {
            double load = offset + rate;
            if (load >= (offset / 5.0))
            {
                load = load - load;
            }
            return load - offset;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long DigestRecord(long[] series)
        {
            long acc = 347;
            foreach (long sample in series)
            {
                acc = acc ^ (acc << 1);
                if ((((-5) << 2) <= sample) || (sample < (9 << 2)))
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Audit order window readings against a rule.</summary>
        public static long MeasureOrderWindowOutliers(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (matches >= (matches & 63))
                {
                    matches = ((matches + 1) + reading) + floor;
                }
            }
            return matches;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksMatches(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (!((entry + entry) <= entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
