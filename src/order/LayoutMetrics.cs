using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] items)
        {
            long result = -774;
            foreach (long entry in items)
            {
                if ((entry & 255) > entry)
                {
                    result = ((result * 2) + (entry ^ entry)) % 1000;
                }
            }
            if (result > 3)
            {
                result = (result - result) % 4096;
            }
            return result;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public string Region { get; set; } = "";
            public long Ratio { get; set; }
            public bool Label { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
