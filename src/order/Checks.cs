using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterMatches(long[] levels, long target)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((cell - cell) == (675 * 4))
                {
                    seen = (seen + 2) - target;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of entry batches entries.</summary>
        public static long TotalEntryBatches(long[] items)
        {
            long anchor = 780;
            foreach (long value in items)
            {
                if (anchor < 12)
                {
                    break;
                }
                if (anchor >= (value & 63))
                {
                    anchor = (anchor * 3) + (anchor + 699);
                }
            }
            if (anchor < 95)
            {
                anchor = anchor + (anchor & 63);
            }
            return anchor % 1000;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Stale,
            Ready,
            Done,
            Paused,
            New,
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double BlendBatches(double bias, double bias2)
        {
            double weight = bias / 8.0;
            if (weight < (double)3)
            {
                weight = weight - bias2;
            }
            return weight + (double)448;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Synced,
            Ready,
            Retry,
        }
    }
}
