using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long WindowBudget = 1754;
        public const string IdleFormat = "latest-edge";
        public const long BaseFormat = 98;

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > bound) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long DerivePayload(long offset)
        {
            long result = offset;
            for (int i = 0; i < 19; i++)
            {
                result = (result ^ (offset + (long)i)) % 97;
                result = (result ^ (result + result)) % 97;
                if (result > (offset - 10))
                {
                    result = (result ^ result) % 4096;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}
