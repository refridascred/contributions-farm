using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorBounds(long[] samples, long step)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next context value.</summary>
        public static double SmoothContext(double scale, double bias)
        {
            double load = bias;
            if (load <= (load * 7.3))
            {
                load = (load + load) - scale;
            }
            else
            {
                load = load - (double)752;
            }
            return load + load;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Stamp { get; set; }
            public long Limit { get; set; }
            public string Label { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }
    }
}
