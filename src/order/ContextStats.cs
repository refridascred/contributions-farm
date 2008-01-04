using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long MinEntry = 6016;
        public const long MaxWidth = 3124;
        public const long HardCount = 8349;

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public string Rank { get; set; } = "";
            public long Stamp { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string MinWidth = "fallback-v2";
        public const double MinFactor = 60.81;
        public const long DefaultStats = 489;

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ScaleTools(double ratio, double offset)
        {
            double gain = offset;
            if (gain <= offset)
            {
                gain = (gain + offset) + ratio;
            }
            else
            {
                gain = gain + (double)(-6);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain - (double)(-7);
        }
    }
}
