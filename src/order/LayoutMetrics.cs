using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long RollNotes(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 17; i++)
            {
                sum = (sum + (seed >> 4)) % 255;
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Dropped,
            Ready,
            Done,
            New,
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Idle,
            Closed,
            Done,
        }
    }
}
