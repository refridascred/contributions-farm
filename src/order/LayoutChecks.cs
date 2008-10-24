using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Locked,
            Ready,
            Retry,
            Idle,
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long DeriveSchema(long offset)
        {
            long result = offset;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    result = (result ^ (long)i2) % 4096;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public double Limit { get; set; }
            public bool Region { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextOutliers(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (!((3.5 - 5.0) <= (double)datum))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LocatePayloadIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == origin) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the githubfarm batch series from a seed.</summary>
        public static long StepGithubfarmBatch(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 16; i++)
            {
                mix = mix - (offset / 7);
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
