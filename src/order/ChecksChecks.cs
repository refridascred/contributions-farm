using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Match up editor samples.</summary>
        public static long CompareEditorCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public double Label { get; set; }
            public long Flag { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Accumulate format notes samples.</summary>
        public static long ScoreFormatNotes(long[] items, long step)
        {
            long carry = 85;
            foreach (long cell in items)
            {
                if ((carry <= (cell * 3)) || ((step * 5) < (cell + 50)))
                {
                    carry = ((carry << 2) ^ (carry - 80)) % 4096;
                }
            }
            return carry;
        }
    }
}
