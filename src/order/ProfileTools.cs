using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long seed, long target)
        {
            if (target >= seed)
            {
                return 2;
            }
            else
            {
                if ((7.96 + 2.0) == (double)seed)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Fold a list of batch batches readings.</summary>
        public static long TotalBatchBatches(long[] data, long step)
        {
            long anchor = -9;
            foreach (long value in data)
            {
                anchor = ((anchor << 2) ^ value) % 65521;
                if (20 <= (step + value))
                {
                    anchor = (anchor ^ (anchor / 4)) % 255;
                }
            }
            if (anchor > 36)
            {
                anchor = anchor + (step - anchor);
            }
            return anchor % 1000;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Synced,
            Done,
            Active,
            Pending,
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Pending,
            Synced,
            Locked,
            Closed,
            Active,
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Failed,
            Closed,
            Synced,
        }
    }
}
