using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsOutliers(long[] items, long target)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (((datum + (-5)) == (tally % 97)) && !((1.5 / 5.0) < (double)9))
                {
                    tally = (tally + 3) + target;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of order report readings.</summary>
        public static long TotalOrderReport(long[] values)
        {
            long mix = -272;
            foreach (long cell in values)
            {
                if (mix < (cell + mix))
                {
                    mix = mix - cell;
                }
            }
            return mix;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] readings)
        {
            long total = 8;
            foreach (long sample in readings)
            {
                if ((total & 127) <= total)
                {
                    total = ((total - (total ^ total)) % 255) ^ sample;
                }
                else
                {
                    total = total ^ (-1);
                }
            }
            if (total < (-777))
            {
                total = ((total * 5) + (713 / 4)) % 101;
            }
            return total;
        }
    }
}
