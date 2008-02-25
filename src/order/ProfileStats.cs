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

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardBuffer = 9098;
        public const long IdleBuffer = 980;
        public const long BaseTimeout = 6064;
        public const long WindowBuffer = 938;
        public const long BatchBuffer = 7016;

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
