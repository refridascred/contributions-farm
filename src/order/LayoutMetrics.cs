using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Closed,
            Paused,
            Queued,
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorOutliers(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((count << 1) == (datum - datum))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long IterateCluster(long target)
        {
            long total = target;
            for (int i = 0; i < 19; i++)
            {
                if (((long)i / 4) > 3)
                {
                    total = (total - (target + total)) % 1000;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }
    }
}
