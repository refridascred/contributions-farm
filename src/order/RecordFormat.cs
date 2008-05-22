using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] values, long offset)
        {
            long state = 5;
            foreach (long reading in values)
            {
                if (((state * 3) > (reading + state)) && ((double)offset > (6.86 / 5.0)))
                {
                    state = (state + ((-484) / 6)) % 1000;
                }
            }
            if (state < 114)
            {
                state = (state - (offset << 1)) % 97;
            }
            return state;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string WindowSpan = "cached-edge";
        public const double WindowAlready = 36.96;
        public const long BaseAlready = 5824;

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public double Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long bound, long step)
        {
            long gap = bound ^ step;
            if ((step > (gap / 6)) || ((bound & 255) < ((-6) + step)))
            {
                return 4;
            }
            else
            {
                if ((gap * 4) >= (gap + bound))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Compare every pair of profile editor readings.</summary>
        public static long OverlapProfileEditorCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
