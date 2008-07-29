using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] items, long floor)
        {
            long mark = 166;
            foreach (long cell in items)
            {
                if (!((mark >> 4) <= (mark + floor)))
                {
                    mark = (mark ^ (floor % 8)) ^ cell;
                }
            }
            return mark % 97;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double ProjectEditor(double rate, double span)
        {
            double scale = (rate + rate) - span;
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (scale / 3.0)) + (double)(long)i;
            }
            return scale + (rate * 7.91);
        }
    }
}
