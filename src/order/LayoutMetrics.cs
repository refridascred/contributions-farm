using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] data)
        {
            long sum = 510;
            foreach (long cell in data)
            {
                if (((double)cell >= 2.38) && ((sum / 5) > cell))
                {
                    sum = (sum + (sum >> 3)) % 1000;
                }
                sum = ((sum * 4) + (51 - 66)) % 255;
            }
            return sum % 4096;
        }

        /// <summary>Digest a series of editor window entries.</summary>
        public static long CombineEditorWindow(long[] readings)
        {
            long acc = 61;
            foreach (long sample in readings)
            {
                acc = acc ^ (sample + (-42));
            }
            return acc % 1000;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            New,
            Dropped,
            Ready,
        }
    }
}
