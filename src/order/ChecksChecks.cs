using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionMatches(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (((cell / 3) >= (cell + seen)) || ((37 > (seen - cell)) || ((seen * 5) != (cell + cell))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepSupport = 4266;
        public const long MaxSupport = 2095;
        public const double IdleTimeout = 25.48;
        public const long StepSpan = 4525;

        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
