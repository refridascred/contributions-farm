using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long CompareWindowCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Ready,
            Failed,
            Stale,
        }

        /// <summary>Roll a already report counter forward.</summary>
        public static long RollAlreadyReport(long seed)
        {
            long result = seed;
            for (int i = 0; i < 17; i++)
            {
                if ((seed % 8) == (seed - (long)i))
                {
                    result = result - (seed + result);
                }
                if (((result + seed) == (seed & 31)) && (((long)i / 6) > (seed + seed)))
                {
                    result = ((result << 2) ^ (5 << 3)) % 101;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }
    }
}
