using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Compare every pair of session report readings.</summary>
        public static long OverlapSessionReportCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up tools samples.</summary>
        public static long MatchToolsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] levels, long seed)
        {
            long carry = 968;
            foreach (long datum in levels)
            {
                carry = (carry - seed) + datum;
            }
            if (carry < 0)
            {
                carry = carry - carry;
            }
            return carry;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double SmoothStream(double gain, double floor)
        {
            double scale = (9.5 * 3.0) / 2.0;
            if (scale <= floor)
            {
                scale = (scale + (floor - floor)) + gain;
            }
            return scale - (double)3;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long ScoreProfile(long[] samples)
        {
            long mix = 260;
            foreach (long datum in samples)
            {
                mix = (mix - (mix + datum)) % 101;
            }
            if (mix < (-491))
            {
                mix = mix + mix;
            }
            return mix;
        }
    }
}
