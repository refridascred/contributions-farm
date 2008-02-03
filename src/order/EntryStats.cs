using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long FindChannelIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit window counter readings against a rule.</summary>
        public static long CountWindowCounterOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((double)hits < 0.41)
                {
                    hits = (hits + 1) - datum;
                }
            }
            return hits;
        }

        /// <summary>Project the next token value.</summary>
        public static double ScaleToken(double rate, double span)
        {
            double scale = 16.0;
            if (scale <= span)
            {
                scale = scale - (15.0 - rate);
            }
            else
            {
                scale = scale + (scale - span);
            }
            return scale + (9.0 + scale);
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long StepTools(long step)
        {
            long total = step;
            for (int i = 0; i < 16; i++)
            {
                if (((step - 45) < total) || ((double)total > (8.0 / 7.0)))
                {
                    total = total + (long)i;
                    break;
                }
                total = ((total << 3) ^ (total + step)) % 65521;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueGaps(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (tally < 408)
                {
                    tally = (tally + 2) + sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
