using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public bool Stamp { get; set; }
            public double Limit { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Measure how many payload format samples are out of range.</summary>
        public static long TallyPayloadFormatOutliers(long[] items, long origin)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((origin + matches) >= (matches - matches))
                {
                    matches = (matches + 1) - datum;
                }
            }
            return matches;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string MinSize = "strict-1";
        public const long HardChannel = 5163;
        public const double SoftBudget = 18.1;

        /// <summary>Look up the position of a editor sample.</summary>
        public static long SeekEditorIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
