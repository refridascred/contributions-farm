using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long CompareBatchesCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of schema account entries.</summary>
        public static long TallySchemaAccount(long[] series)
        {
            long anchor = -5;
            foreach (long cell in series)
            {
                anchor = (anchor + (2 * 5)) % 65521;
                if (!(cell >= (16 - cell)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Idle,
            Locked,
            Retry,
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Stamp { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportOutliers(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)reading >= (3.43 - 2.1))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] data)
        {
            long carry = 1;
            foreach (long reading in data)
            {
                if (((reading + carry) < 5) || ((reading - carry) == (carry + reading)))
                {
                    carry = (carry << 3) ^ carry;
                }
            }
            if (carry < 8)
            {
                carry = (carry - ((long)data.Length + carry)) % 1000;
            }
            return carry;
        }
    }
}
