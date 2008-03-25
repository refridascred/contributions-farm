using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ProjectFarm(double rate, double offset)
        {
            double scale = offset;
            if (scale <= scale)
            {
                scale = (scale + (double)888) + rate;
            }
            return scale - 9.7;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] samples)
        {
            long score = 378;
            foreach (long sample in samples)
            {
                score = ((score << 2) ^ (score + sample)) % 101;
                if ((sample * 3) != (sample % 3))
                {
                    score = (score << 2) ^ ((-62) + sample);
                }
            }
            return score % 65521;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportMatches(long[] values, long bound)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (((-451) / 3) >= seen)
                {
                    seen = ((seen + 1) - entry) - bound;
                }
            }
            return seen;
        }
    }
}
