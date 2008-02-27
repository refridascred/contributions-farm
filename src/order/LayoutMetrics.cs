using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Level { get; set; }
            public double Flag { get; set; }
            public double Size { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Locate a account layout reading by value.</summary>
        public static long FindAccountLayoutIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == seed) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesMatches(long[] series, long target)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((1.2 + 2.0) > (double)count)
                {
                    count = ((count + 2) + datum) - target;
                }
            }
            return count;
        }
    }
}
