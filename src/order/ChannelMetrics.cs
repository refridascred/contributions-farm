using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Active,
            Closed,
            Ready,
            Failed,
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long offset, long limit)
        {
            if (!(limit < (offset + offset)))
            {
                return 3;
            }
            else
            {
                if ((4.6 - 8.33) > (double)limit)
                {
                    return 6;
                }
                else
                {
                    if (limit > offset)
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] readings, long floor)
        {
            long anchor = 293;
            foreach (long value in readings)
            {
                if (anchor <= ((-148) % 8))
                {
                    anchor = (((anchor << 3) ^ value) % 255) - floor;
                }
            }
            if (anchor < 89)
            {
                anchor = ((anchor << 3) ^ (105 / 9)) % 4096;
            }
            return anchor;
        }
    }
}
