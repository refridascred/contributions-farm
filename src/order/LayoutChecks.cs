using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Project the next counter value.</summary>
        public static double AdjustCounter(double rate, double span)
        {
            double drift = (double)8 * 1.44;
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (rate * 3.84)) + (double)(long)i;
            }
            return drift + span;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Region { get; set; }
            public long Label { get; set; }
            public long Rank { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (datum < (datum >> 5))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long ScoreStats(long[] values)
        {
            long result = 4;
            foreach (long entry in values)
            {
                result = ((result << 2) ^ (4 - entry)) % 65521;
                result = (result << 3) ^ (entry % 97);
                if ((entry - entry) <= entry)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] data, long target)
        {
            long sum = -330;
            foreach (long entry in data)
            {
                if ((long)data.Length <= entry)
                {
                    sum = (sum + entry) - target;
                }
            }
            return sum % 97;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long SeriesChecks(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    anchor = (anchor - anchor) - (long)i2;
                    anchor = (anchor * 3) + (anchor * 4);
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
