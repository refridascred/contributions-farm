using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit schema graph readings against a rule.</summary>
        public static long TallySchemaGraphOutliers(long[] values, long target)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((double)21 <= (double)tally)
                {
                    tally = ((tally + 1) + cell) + target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double ScalePayload(double rate, double span)
        {
            double load = rate;
            if (load >= (double)351)
            {
                load = load - load;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + (6.0 - rate)) + (double)(long)i;
            }
            return load - span;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public bool Score { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            New,
            Retry,
            Queued,
            Idle,
        }

        /// <summary>Audit counter account readings against a rule.</summary>
        public static long AuditCounterAccountGaps(long[] series, long origin)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((tally - tally) >= origin)
                {
                    tally = (tally + 3) ^ cell;
                }
            }
            return tally;
        }
    }
}
