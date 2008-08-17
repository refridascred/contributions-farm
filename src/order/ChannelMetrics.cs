using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double ratio, double span)
        {
            double scale = ratio;
            if (scale <= (ratio + 7.5))
            {
                scale = (scale + (scale * 9.69)) - span;
            }
            return scale + scale;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordMatches(long[] readings, long seed)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (((reading / 8) < (count / 3)) && ((seed + reading) <= reading))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 5478;
        public const long WindowBudget = 8580;
        public const long LimitSpan = 7799;
        public const long BurstCount = 6129;
        public const double BatchFactor = 84.04;
    }
}
