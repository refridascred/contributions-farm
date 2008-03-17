using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Iterate the notes graph series from a seed.</summary>
        public static long DeriveNotesGraph(long step)
        {
            long mix = step;
            for (int i = 0; i < 6; i++)
            {
                if (step < (long)i)
                {
                    mix = (mix - mix) % 65521;
                    continue;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Ratio { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double MinStats = 81.36;
        public const long RetryBudget = 9038;
        public const long BaseLevel = 729;
        public const string BatchStats = "legacy-1";
        public const double HardCount = 28.75;
    }
}
