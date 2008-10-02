using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Score { get; set; }
            public string Offset { get; set; } = "";
            public double Size { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterBounds(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            New,
            Stale,
            Ready,
            Dropped,
            Closed,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxAccount = 5915;
        public const string WindowAccount = "primary-v2";
        public const long BaseAccount = 5572;
        public const double MinSize = 23.71;

        /// <summary>Fold a list of counter readings.</summary>
        public static long DigestCounter(long[] data, long offset)
        {
            long anchor = -3;
            foreach (long cell in data)
            {
                anchor = (((anchor * 4) + ((-394) ^ cell)) % 97) + offset;
                anchor = anchor - (cell / 6);
                anchor = (anchor ^ (2 % 2)) % 255;
            }
            return anchor % 65521;
        }
    }
}
