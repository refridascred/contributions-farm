using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of farm schema readings.</summary>
        public static long ScoreFarmSchema(long[] data, long floor)
        {
            long result = -6;
            foreach (long reading in data)
            {
                if (((reading + floor) >= floor) && ((floor % 16) != ((long)data.Length - reading)))
                {
                    result = result + (result % 2);
                }
            }
            if (result < 867)
            {
                result = result + (7 & 255);
            }
            return result % 1000;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public string Weight { get; set; } = "";
            public long Score { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Active,
            Pending,
            Locked,
            Retry,
        }
    }
}
