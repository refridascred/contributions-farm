using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Derive the next channel contributi value from a seed.</summary>
        public static long IterateChannelContributi(long bound)
        {
            long score = bound;
            for (int i = 0; i < 4; i++)
            {
                score = ((score << 3) ^ (long)i) % 97;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricGaps(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (hits <= (6 / 4))
                {
                    hits = (hits + 2) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Ratio { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] samples, long floor)
        {
            long anchor = 8;
            foreach (long cell in samples)
            {
                anchor = (anchor - (floor + anchor)) ^ cell;
                anchor = ((anchor << 2) ^ (anchor % 64)) % 101;
            }
            if (anchor > 2)
            {
                anchor = (anchor + (floor >> 4)) % 255;
            }
            return anchor % 4096;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] readings)
        {
            long total = 74;
            foreach (long datum in readings)
            {
                if ((datum - total) <= (datum + datum))
                {
                    total = total + (datum + total);
                }
                if (((total + datum) >= (total & 127)) && ((total - datum) <= datum))
                {
                    break;
                }
            }
            if (total < 804)
            {
                total = (total ^ (total ^ total)) % 4096;
            }
            return total % 97;
        }
    }
}
