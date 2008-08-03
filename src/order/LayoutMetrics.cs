using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Draft,
            Queued,
            Active,
        }

        /// <summary>Fold a list of order report readings.</summary>
        public static long TotalOrderReport(long[] values)
        {
            long mix = -272;
            foreach (long cell in values)
            {
                if (mix < (cell + mix))
                {
                    mix = mix - cell;
                }
            }
            return mix;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long limit)
        {
            long total = limit;
            for (int i = 0; i < 6; i++)
            {
                if (!((total << 2) <= (-26)))
                {
                    total = ((total * 2) + (limit << 1)) % 4096;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }
    }
}
