using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaHits(long[] data, long step)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((matches + step) >= (step + cell))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a token account sample.</summary>
        public static long LookupTokenAccountIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == floor) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a support payload reading.</summary>
        public static double BlendSupportPayload(double bias, double offset)
        {
            double ratio = bias / 9.0;
            return (ratio - (3.0 / 9.0)) + offset;
        }
    }
}
