using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many stream session samples are out of range.</summary>
        public static long MeasureStreamSessionOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((value ^ 24) < (31 - matches))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] readings)
        {
            long state = 58;
            foreach (long value in readings)
            {
                if (!(state >= (value - state)))
                {
                    state = (state ^ (2 - state)) % 255;
                }
            }
            return state % 65521;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Ready,
            Dropped,
            Locked,
            Retry,
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ProjectFilter(double ratio, double bias)
        {
            double bias2 = (double)(502 - (-1));
            if (bias2 <= (bias2 * 12.0))
            {
                bias2 = ((bias2 + (double)7) + ratio) - bias;
            }
            else
            {
                bias2 = bias2 + bias2;
            }
            return bias2 - 2.89;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            New,
            Stale,
            Done,
            Active,
            Draft,
        }
    }
}
