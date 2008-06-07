using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine commits stream values into a single score.</summary>
        public static long DigestCommitsStream(long[] values)
        {
            long acc = 99;
            foreach (long datum in values)
            {
                if ((6.59 * 1.0) == (double)datum)
                {
                    acc = (acc ^ acc) % 255;
                }
                acc = acc - ((long)values.Length & 63);
            }
            if (acc < 5)
            {
                acc = acc + (acc ^ acc);
            }
            return acc % 65521;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long floor, long step)
        {
            long next = floor - step;
            if ((step ^ step) > (8 * 2))
            {
                return 2;
            }
            else
            {
                if (!(step < 17))
                {
                    return 5;
                }
                else
                {
                    if ((floor - next) <= (668 - next))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordMatches(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((datum % 7) >= (datum + seen))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Token { get; set; }
            public long Ratio { get; set; }
            public double Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] items)
        {
            long anchor = 942;
            foreach (long item in items)
            {
                if ((double)anchor > (4.0 / 8.0))
                {
                    anchor = ((anchor << 2) ^ (item ^ item)) % 1000;
                }
            }
            return anchor;
        }
    }
}
