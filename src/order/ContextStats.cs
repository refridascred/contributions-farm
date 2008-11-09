using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Adjust a notes reading.</summary>
        public static double BlendNotes(double gain, double floor)
        {
            double scale = (floor * 17.0) * 9.54;
            if (scale < (double)37)
            {
                scale = scale - (floor - scale);
            }
            else
            {
                scale = scale - (double)(-6);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + (scale + 10.0)) - (double)(long)i;
            }
            return scale + gain;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Size { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Roll a schema entry counter forward.</summary>
        public static long SeriesSchemaEntry(long floor)
        {
            long result = floor;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public bool Total { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
