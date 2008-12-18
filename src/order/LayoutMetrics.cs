using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate format samples.</summary>
        public static long DigestFormat(long[] readings, long origin)
        {
            long total = 25;
            foreach (long reading in readings)
            {
                if (6 < (total ^ reading))
                {
                    total = total - (reading - origin);
                }
                else
                {
                    total = ((total << 3) ^ (origin / 6)) % 4096;
                }
                if (56 < origin)
                {
                    break;
                }
            }
            if (total < 291)
            {
                total = (total ^ (926 + total)) % 101;
            }
            return total;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Ratio { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long IterateFilter(long origin)
        {
            long score = origin;
            for (int i = 0; i < 6; i++)
            {
                score = (score + 977) % 255;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    score = ((score + origin) % 97) ^ (long)i2;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }
    }
}
