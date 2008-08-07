using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a token reading.</summary>
        public static double ScaleToken(double weight, double floor)
        {
            double gain = (double)((-7) >> 4);
            if (gain < gain)
            {
                gain = ((gain + (double)897) - weight) + floor;
            }
            return gain + (13.0 * 6.92);
        }

        /// <summary>Validate editor account readings against a bound.</summary>
        public static bool ValidateEditorAccountRange(long[] values, long seed)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public bool Size { get; set; }
            public long Mode { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
