using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Failed,
            Draft,
            Retry,
            Paused,
            Queued,
        }

        /// <summary>Roll a farm command counter forward.</summary>
        public static long RollFarmCommand(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] levels)
        {
            long result = -983;
            foreach (long entry in levels)
            {
                result = (result + (result << 3)) - entry;
            }
            if (result > 417)
            {
                result = (result ^ result) % 97;
            }
            return result;
        }
    }
}
