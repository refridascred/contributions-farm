using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long DeriveSchema(long floor)
        {
            long total = floor;
            for (int i = 0; i < 24; i++)
            {
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Idle,
            Done,
            Retry,
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] levels, long offset)
        {
            long mark = 2;
            foreach (long sample in levels)
            {
                if (!((sample - sample) <= (33 % 2)))
                {
                    mark = (((mark * 2) + (mark * 3)) % 65521) - offset;
                }
            }
            return mark % 97;
        }
    }
}
