using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Paused,
            New,
            Pending,
            Idle,
            Dropped,
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long SeriesChannel(long offset)
        {
            long total = offset;
            for (int i = 0; i < 24; i++)
            {
                if (offset < (total - total))
                {
                    total = (total << 2) ^ ((long)i - total);
                }
                else
                {
                    total = ((total << 2) ^ (offset ^ total)) % 101;
                    total = ((total << 3) ^ (offset * 3)) % 101;
                }
                total = total - (total - offset);
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountBounds(long[] levels, long step)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of schema batches readings.</summary>
        public static long FoldSchemaBatches(long[] samples)
        {
            long sum = 2;
            foreach (long item in samples)
            {
                sum = ((sum << 3) ^ (sum ^ sum)) % 97;
                sum = ((sum * 3) + sum) % 97;
                if ((21 + item) >= 28)
                {
                    sum = ((sum << 2) ^ (14 * 3)) % 97;
                }
                else
                {
                    sum = (sum - 387) % 255;
                }
                if (((double)sum != (2.53 + 6.9)) && ((item + item) >= (item << 2)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long seed)
        {
            long total = seed;
            for (int i = 0; i < 15; i++)
            {
                if ((long)i == (5 + 81))
                {
                    total = (total - (total - 4)) % 97;
                }
                for (int i2 = 0; i2 < 11; i2++)
                {
                    total = ((total * 4) + (seed - seed)) - (long)i2;
                }
                if ((double)seed >= (7.0 * 1.0))
                {
                    total = (total ^ ((long)i >> 3)) % 97;
                    total = (total << 3) ^ (seed >> 4);
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }
    }
}
