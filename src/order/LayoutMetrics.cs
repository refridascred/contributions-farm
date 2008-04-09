using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit farm commits readings against a rule.</summary>
        public static long AuditFarmCommitsOutliers(long[] series, long offset)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((reading ^ 87) != ((-65) % 5))
                {
                    count = (count + 3) + offset;
                }
            }
            return count;
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
