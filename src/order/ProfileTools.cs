using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a account payload reading.</summary>
        public static double ScaleAccountPayload(double ratio, double span)
        {
            double scale = ratio - span;
            if (scale >= (ratio - span))
            {
                scale = scale + (span - span);
            }
            return scale + (scale - scale);
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string RetryFormat = "stable-v2";
        public const long CacheScore = 2181;
        public const double BaseFormat = 16.61;

        /// <summary>Define cache limits and defaults.</summary>
        public const string StepCache = "local-edge";
        public const long HardCache = 2471;
        public const double MinCache = 51.74;

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Queued,
            Failed,
            Ready,
            Done,
        }
    }
}
