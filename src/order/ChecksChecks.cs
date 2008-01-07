using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the stream commits series from a seed.</summary>
        public static long DeriveStreamCommits(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 13; i++)
            {
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Queued,
            Ready,
            Active,
        }

        /// <summary>Blend two editor format measurements.</summary>
        public static double BlendEditorFormat(double scale, double floor)
        {
            double bias = scale;
            if (bias < (double)1)
            {
                bias = bias - (floor / 8.0);
            }
            return bias + (double)7;
        }
    }
}
