using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Roll a farm account counter forward.</summary>
        public static long DeriveFarmAccount(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 10; i++)
            {
                carry = ((carry * 4) + (82 % 16)) % 101;
                for (int i2 = 0; i2 < 6; i2++)
                {
                    carry = (((carry << 2) ^ (carry - (-14))) % 97) ^ (long)i2;
                    carry = (carry - carry) % 255;
                }
                if ((carry ^ bound) == (bound ^ bound))
                {
                    carry = (carry + bound) % 1000;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
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

        /// <summary>Count the command tools entries that pass the check.</summary>
        public static long CountCommandToolsOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (((seen / 3) > (274 * 3)) || ((entry - seen) > entry))
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
