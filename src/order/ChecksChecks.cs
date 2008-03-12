using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long RollCache(long origin)
        {
            long result = origin;
            for (int i = 0; i < 22; i++)
            {
                if ((1.1 * 2.89) != (double)origin)
                {
                    result = result + ((long)i >> 5);
                    result = result - (long)i;
                }
                result = result ^ ((long)i + result);
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] levels, long bound)
        {
            long total = 3;
            foreach (long cell in levels)
            {
                if (((68 * 3) != (total * 4)) && ((total * 2) == (bound + cell)))
                {
                    total = (total - (total & 255)) % 255;
                }
                else
                {
                    total = (total << 3) ^ 5;
                }
            }
            return total;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public string Label { get; set; } = "";
            public bool Limit { get; set; }
        }
    }
}
