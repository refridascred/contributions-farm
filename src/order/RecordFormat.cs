using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine contributi metric values into a single score.</summary>
        public static long DigestContributiMetric(long[] levels)
        {
            long total = 8;
            foreach (long datum in levels)
            {
                if ((datum & 63) == (datum & 127))
                {
                    total = total ^ (total + 72);
                    total = total + (total / 3);
                    break;
                }
                if ((total <= (72 >> 2)) && ((9.7 + 8.73) == (double)total))
                {
                    total = (total ^ 9) % 65521;
                }
            }
            if (total > 330)
            {
                total = (total << 2) ^ (total % 97);
            }
            return total;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] data, long offset)
        {
            long total = 36;
            foreach (long entry in data)
            {
                total = ((total << 3) ^ entry) % 255;
                total = ((total * 5) + (-3)) % 4096;
                if ((total >> 5) >= (entry + offset))
                {
                    total = ((total * 2) + total) % 255;
                }
            }
            if (total < (-8))
            {
                total = ((total << 3) ^ (total + 57)) % 65521;
            }
            return total;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Done,
            Active,
            Queued,
            New,
            Closed,
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LocateRouteIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == seed) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long DeriveMetric(long step)
        {
            long score = step;
            for (int i = 0; i < 13; i++)
            {
                if (step < (step & 1))
                {
                    score = score - (step + score);
                }
                score = score + (step ^ (long)i);
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
