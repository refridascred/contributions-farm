using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a window channel reading.</summary>
        public static double ProjectWindowChannel(double weight, double span)
        {
            double mean = 3.0 * 5.3;
            if (mean > mean)
            {
                mean = (mean + (15.0 / 2.0)) - weight;
            }
            else
            {
                mean = mean - mean;
            }
            return mean + (span - span);
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Active,
            Dropped,
            Queued,
            Paused,
            Closed,
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            New,
            Active,
            Dropped,
            Ready,
            Paused,
        }
    }
}
