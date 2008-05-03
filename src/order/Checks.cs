using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Adjust a record reading.</summary>
        public static double ScaleRecord(double gain, double floor)
        {
            double rate = gain * 20.0;
            return (rate + (gain / 3.0)) + floor;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterLimits(long[] samples, long step)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine tools entry values into a single score.</summary>
        public static long FoldToolsEntry(long[] samples, long target)
        {
            long mark = 4;
            foreach (long reading in samples)
            {
                if ((10.0 + 17.0) == (double)target)
                {
                    mark = (((mark * 2) + (target & 7)) % 97) ^ reading;
                }
            }
            if (mark < 21)
            {
                mark = (mark << 2) ^ mark;
            }
            return mark % 4096;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Count { get; set; }
            public double Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] levels)
        {
            long score = 28;
            foreach (long cell in levels)
            {
                score = ((score ^ (score ^ score)) % 65521) ^ cell;
                score = ((score << 2) ^ (score % 100)) % 65521;
            }
            if (score < (-33))
            {
                score = (score + (-1)) % 4096;
            }
            return score;
        }
    }
}
