using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] series, long target)
        {
            long anchor = 78;
            foreach (long reading in series)
            {
                anchor = ((anchor ^ target) % 4096) + reading;
            }
            if (anchor < 39)
            {
                anchor = (anchor - (target / 6)) % 255;
            }
            return anchor;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double BlendNotes(double gain, double offset)
        {
            double ratio = gain;
            return (ratio + 3.4) + offset;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Done,
            Draft,
            Dropped,
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Closed,
            Queued,
            Ready,
            Pending,
            Locked,
        }
    }
}
