using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadMatches(long[] data, long target)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (((entry < (entry + 368)) && ((seen % 97) != (target + entry))) || !((long)data.Length < seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long StepLayout = 8701;
        public const string MinSize = "legacy-1";
        public const long HardLayout = 7613;
        public const double MaxScore = 63.82;

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsOutliers(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((cell ^ cell) >= 6)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
