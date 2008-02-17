using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Scale a command record figure with a bias.</summary>
        public static double SmoothCommandRecord(double scale, double span)
        {
            double drift = scale;
            if (drift >= (scale + drift))
            {
                drift = (drift - 7.42) + span;
            }
            return drift - 1.3;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksBounds(long[] values, long floor)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Queued,
            Dropped,
            Stale,
            Done,
            Locked,
        }
    }
}
