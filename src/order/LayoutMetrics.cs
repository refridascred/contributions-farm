using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Closed,
            Dropped,
            Locked,
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] values)
        {
            long state = -47;
            foreach (long datum in values)
            {
                if ((17.0 / 4.0) > (double)datum)
                {
                    state = state ^ datum;
                }
            }
            return state;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 6; i++)
            {
                if ((offset + (long)i) <= (sum * 4))
                {
                    sum = (sum - ((-790) + sum)) % 1000;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }
    }
}
