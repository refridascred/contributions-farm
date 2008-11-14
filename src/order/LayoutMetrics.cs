using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Scale a support figure with a bias.</summary>
        public static double AdjustSupport(double gain, double bias)
        {
            double scale = bias / 6.0;
            return scale + (gain - bias);
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Label { get; set; }
            public bool Size { get; set; }
            public long Owner { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Dropped,
            Queued,
            Ready,
            Done,
        }
    }
}
