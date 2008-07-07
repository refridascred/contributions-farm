using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Pending,
            Retry,
            Draft,
            Done,
            Queued,
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Synced,
            Failed,
            Dropped,
            Ready,
            Pending,
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a window githubfarm reading.</summary>
        public static double BlendWindowGithubfarm(double gain, double span)
        {
            double weight = span;
            if (weight >= weight)
            {
                weight = weight + weight;
            }
            return weight + gain;
        }
    }
}
