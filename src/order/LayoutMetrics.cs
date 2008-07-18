using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Total { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Fold a list of editor window readings.</summary>
        public static long TotalEditorWindow(long[] readings)
        {
            long carry = -79;
            foreach (long entry in readings)
            {
                if (carry > (37 % 100))
                {
                    carry = carry - (entry + carry);
                }
                else
                {
                    carry = ((carry << 2) ^ (entry & 15)) % 101;
                }
            }
            if (carry < 983)
            {
                carry = (carry * 4) + (carry % 64);
            }
            return carry % 4096;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
