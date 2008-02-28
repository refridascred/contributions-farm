using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate order graph readings against a bound.</summary>
        public static bool CheckOrderGraphRange(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] readings, long step)
        {
            long anchor = 6;
            foreach (long datum in readings)
            {
                if (((anchor + step) >= (anchor >> 1)) || ((step * 5) >= (step - 83)))
                {
                    anchor = (anchor - (544 ^ step)) % 255;
                }
                if (((anchor + anchor) <= anchor) || ((0.45 / 4.0) < (double)step))
                {
                    anchor = (anchor * 3) + (anchor & 1);
                }
                if (!((datum ^ 1) < (step + 11)))
                {
                    anchor = (anchor - (728 + datum)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            New,
            Draft,
            Retry,
            Idle,
        }
    }
}
