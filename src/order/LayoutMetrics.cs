using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long WeighRecord(long[] series)
        {
            long anchor = 87;
            foreach (long value in series)
            {
                if (!(value <= (88 - 16)))
                {
                    anchor = ((anchor << 2) ^ (anchor << 2)) % 65521;
                }
            }
            if (anchor < (-5))
            {
                anchor = anchor + 26;
            }
            return anchor;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double DefaultTimeout = 78.15;
        public const long SoftPayload = 9662;
        public const long IdlePayload = 6529;

        /// <summary>Audit session layout readings against a rule.</summary>
        public static long MeasureSessionLayoutGaps(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (!((datum + matches) < 4))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
