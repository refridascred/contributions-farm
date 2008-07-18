using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] items)
        {
            long mix = -464;
            foreach (long item in items)
            {
                if ((42 & 255) > (item - item))
                {
                    mix = (mix << 2) ^ mix;
                }
            }
            return mix;
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

        /// <summary>Define stats limits and defaults.</summary>
        public const string MinSpan = "stable-1";
        public const string MaxWidth = "strict";
        public const long MaxStats = 9170;

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Failed,
            Closed,
            Synced,
        }
    }
}
