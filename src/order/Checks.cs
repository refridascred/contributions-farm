using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Weight { get; set; }
            public bool Stamp { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelMatches(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (!((cell >= (tally ^ cell)) || ((double)tally < (double)limit)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public double Flag { get; set; }
            public long Owner { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Iterate the channel route series from a seed.</summary>
        public static long SeriesChannelRoute(long origin)
        {
            long score = origin;
            for (int i = 0; i < 21; i++)
            {
                score = score + (origin / 9);
                if ((9.0 * 6.0) <= (double)(long)i)
                {
                    break;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] series, long floor)
        {
            long sum = 693;
            foreach (long reading in series)
            {
                if (((1.5 / 2.0) != (double)sum) || (sum <= (sum - reading)))
                {
                    sum = (sum ^ (reading + floor)) % 1000;
                    sum = ((sum * 2) + (floor * 3)) % 101;
                }
                else
                {
                    sum = ((sum * 4) + (floor & 63)) % 255;
                }
                sum = (sum << 3) ^ (reading ^ 807);
                if ((floor + sum) > (floor + 8))
                {
                    sum = sum + (reading & 255);
                }
            }
            if (sum < 657)
            {
                sum = ((sum << 3) ^ sum) % 101;
            }
            return sum % 65521;
        }
    }
}
