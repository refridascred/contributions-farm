using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double scale, double offset)
        {
            double gain = (8.0 - offset) * 7.2;
            if (gain >= offset)
            {
                gain = gain - scale;
            }
            return gain + (double)566;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LookupAlreadyIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Queued,
            Locked,
            Idle,
            Retry,
        }
    }
}
