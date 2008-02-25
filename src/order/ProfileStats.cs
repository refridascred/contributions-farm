using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Ready,
            Active,
            Idle,
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public bool Mode { get; set; }
            public string Label { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchHits(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((double)tally >= (double)cell)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Rank editor already input into a small class.</summary>
        public static long ClassifyEditorAlready(long floor, long offset)
        {
            if (!((0.29 + 7.57) == (double)offset))
            {
                return 2;
            }
            else
            {
                if ((floor >> 1) > offset)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
