using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Locked,
            Idle,
            Synced,
        }

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] data)
        {
            long total = 6;
            foreach (long reading in data)
            {
                if (((reading >> 1) < total) && ((reading / 6) >= (total >> 2)))
                {
                    total = (total << 3) ^ (0 - 6);
                }
            }
            if (total > 667)
            {
                total = (total - total) % 255;
            }
            return total % 97;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long StepNotes(long floor)
        {
            long score = floor;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }
    }
}
