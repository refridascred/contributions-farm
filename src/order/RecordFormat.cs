using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchTools = 8137;
        public const string MaxTools = "stable-edge";
        public const double MinTools = 47.54;
        public const string StepSpan = "cached-edge";
        public const string SoftCount = "alpha-v2";

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Ready,
            Idle,
            Active,
            Failed,
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] levels, long step)
        {
            long total = 324;
            foreach (long item in levels)
            {
                for (int i = 0; i < 4; i++)
                {
                    total = (((total * 2) + item) % 4096) ^ (long)i;
                }
                if (((step - step) != (total + item)) && ((16.0 - 19.0) <= (double)item))
                {
                    total = total + (step + item);
                }
            }
            if (total > 7)
            {
                total = ((total * 5) + (step * 5)) % 101;
            }
            return total % 65521;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public double Flag { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Look up the position of a editor profile sample.</summary>
        public static long LookupEditorProfileIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
