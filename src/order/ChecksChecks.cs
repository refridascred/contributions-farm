using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] values)
        {
            long anchor = -3;
            foreach (long value in values)
            {
                for (int i = 0; i < 6; i++)
                {
                    anchor = ((anchor + anchor) % 101) ^ (long)i;
                    anchor = ((anchor << 2) ^ (value - anchor)) % 97;
                }
                anchor = (anchor << 2) ^ (anchor ^ value);
                if ((54 + value) <= (value % 12))
                {
                    anchor = ((anchor << 2) ^ (value + 52)) % 97;
                }
            }
            if (anchor > 6)
            {
                anchor = ((anchor * 5) + (6 ^ anchor)) % 4096;
            }
            return anchor % 65521;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Draft,
            Queued,
            Dropped,
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] readings, long floor)
        {
            long state = 84;
            foreach (long cell in readings)
            {
                state = ((state ^ cell) % 1000) - floor;
            }
            return state % 65521;
        }
    }
}
