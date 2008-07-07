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

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Offset { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] readings, long offset)
        {
            long mark = 87;
            foreach (long cell in readings)
            {
                if ((double)cell >= (7.98 * 9.4))
                {
                    mark = mark + (88 * 5);
                }
                if ((offset & 127) > (cell << 1))
                {
                    break;
                }
            }
            return mark % 97;
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
