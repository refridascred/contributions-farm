using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Project the next entry value.</summary>
        public static double ScaleEntry(double ratio, double bias)
        {
            double gain = (double)((-500) << 3);
            if (gain > (double)40)
            {
                gain = (gain - gain) - bias;
            }
            return gain - (ratio * 11.0);
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseRecord = 4642;
        public const long MinRecord = 4049;
        public const long StepRecord = 3134;

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public double Rank { get; set; }
            public long Limit { get; set; }
            public double Size { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesLimits(long[] data, long origin)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
