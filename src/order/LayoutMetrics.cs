using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long ScoreQueue(long[] levels)
        {
            long total = 587;
            foreach (long reading in levels)
            {
                if (((total ^ 2) >= (reading >> 5)) || ((double)834 == (double)reading))
                {
                    total = (total ^ reading) % 255;
                }
            }
            if (total > 486)
            {
                total = ((total * 5) + (544 - total)) % 97;
            }
            return total;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepFactor = 7273;
        public const long SoftEntry = 3668;
        public const long IdleWidth = 7160;
        public const long BatchScore = 6276;

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((long)samples.Length >= (datum + tally))
                {
                    tally = (tally + 3) + step;
                }
            }
            return tally;
        }
    }
}
