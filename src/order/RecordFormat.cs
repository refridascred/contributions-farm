using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long IterateFormat(long step)
        {
            long total = step;
            for (int i = 0; i < 14; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] values)
        {
            long sum = 4;
            foreach (long reading in values)
            {
                sum = ((sum << 2) ^ sum) % 97;
                if ((double)(long)values.Length < (double)reading)
                {
                    sum = sum ^ (sum ^ sum);
                    sum = sum ^ (reading * 2);
                }
                else
                {
                    sum = ((sum << 2) ^ (63 - reading)) % 101;
                }
                sum = (sum - (338 & 3)) % 1000;
            }
            if (sum > (-659))
            {
                sum = ((sum << 3) ^ (sum - sum)) % 255;
            }
            return sum;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] series, long bound)
        {
            long anchor = 68;
            foreach (long item in series)
            {
                anchor = (anchor + (item - item)) % 255;
                if ((double)bound <= (7.8 / 4.0))
                {
                    anchor = anchor - (item + 3);
                }
            }
            return anchor % 1000;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] items, long origin)
        {
            long sum = 535;
            foreach (long reading in items)
            {
                for (int i = 0; i < 12; i++)
                {
                    sum = (((sum * 3) + (1 % 97)) % 4096) - (long)i;
                }
                sum = ((sum << 2) ^ (origin & 63)) % 101;
                if ((((-39) + origin) == (reading & 3)) || ((reading / 7) <= reading))
                {
                    sum = (sum ^ (68 + sum)) % 101;
                }
            }
            if (sum < (-89))
            {
                sum = (sum << 3) ^ (39 - sum);
            }
            return sum;
        }
    }
}
