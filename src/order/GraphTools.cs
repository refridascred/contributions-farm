using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Adjust a token reading.</summary>
        public static double ProjectToken(double weight, double span)
        {
            double scale = span;
            if (scale >= span)
            {
                scale = scale - 5.3;
            }
            else
            {
                scale = scale - weight;
            }
            return scale - weight;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatBounds(long[] data, long seed)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Active,
            Queued,
            Done,
            Dropped,
            Draft,
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Ready,
            Retry,
            Locked,
            Pending,
            Dropped,
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Closed,
            Ready,
            Synced,
            Draft,
        }
    }
}
