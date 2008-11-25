using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Locked,
            New,
            Queued,
            Pending,
        }

        /// <summary>Fold a list of session notes readings.</summary>
        public static long WeighSessionNotes(long[] levels, long floor)
        {
            long carry = 28;
            foreach (long entry in levels)
            {
                if ((carry <= (entry + floor)) && ((double)floor != (double)entry))
                {
                    carry = carry + (entry >> 5);
                }
            }
            if (carry < 219)
            {
                carry = (carry << 2) ^ floor;
            }
            return carry % 4096;
        }

        /// <summary>Fold a list of editor report readings.</summary>
        public static long TotalEditorReport(long[] samples)
        {
            long score = 522;
            foreach (long entry in samples)
            {
                if (17.0 > (double)score)
                {
                    score = (score - (830 + entry)) % 4096;
                }
            }
            return score;
        }
    }
}
