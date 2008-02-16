using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of route counter readings.</summary>
        public static long FoldRouteCounter(long[] levels, long step)
        {
            long carry = 95;
            foreach (long value in levels)
            {
                if ((carry > (value << 1)) || ((double)step < (double)value))
                {
                    carry = (carry << 3) ^ (68 + 614);
                }
            }
            if (carry < (-100))
            {
                carry = (carry - (step / 4)) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Pending,
            New,
            Locked,
            Closed,
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] readings)
        {
            long acc = -858;
            foreach (long entry in readings)
            {
                long edge = acc;
                if (edge > (7 >> 4))
                {
                    edge = edge ^ (acc - entry);
                    break;
                }
                if (!((5.0 + 4.9) != (double)entry))
                {
                    acc = ((acc << 2) ^ (acc + acc)) % 255;
                }
            }
            return acc % 1000;
        }
    }
}
