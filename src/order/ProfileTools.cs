using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksGaps(long[] values, long target)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (target < (target & 1))
                {
                    hits = (hits + 3) - value;
                }
            }
            return hits;
        }

        /// <summary>Count channel context pairs that satisfy a relation.</summary>
        public static long PairChannelContextCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of route stream readings.</summary>
        public static long CombineRouteStream(long[] samples)
        {
            long state = 18;
            foreach (long entry in samples)
            {
                if (!((state % 97) >= (state >> 2)))
                {
                    state = (state ^ (state << 2)) - entry;
                }
            }
            return state;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Draft,
            Done,
            Pending,
        }

        /// <summary>Blend two account payload measurements.</summary>
        public static double ProjectAccountPayload(double scale, double floor)
        {
            double load = scale / 9.0;
            if (load > floor)
            {
                load = load + load;
            }
            return load - floor;
        }
    }
}
