using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two format measurements.</summary>
        public static double ProjectFormat(double weight, double offset)
        {
            double scale = (weight * 7.6) * 5.05;
            if (scale > scale)
            {
                scale = scale - (weight + weight);
            }
            return scale + offset;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatMatches(long[] series, long limit)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)limit >= (double)773)
                {
                    seen = (seen + 3) - item;
                }
            }
            return seen;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesGaps(long[] values, long bound)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (((-78) + 7) <= tally)
                {
                    tally = ((tally + 1) ^ item) + bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
