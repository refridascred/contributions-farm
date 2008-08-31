using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the route series from a seed.</summary>
        public static long RollRoute(long step)
        {
            long total = step;
            for (int i = 0; i < 4; i++)
            {
                if (step < ((long)i << 1))
                {
                    total = total - (step + step);
                }
                else
                {
                    total = total ^ step;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Ready,
            Idle,
            Queued,
            Failed,
            Paused,
        }

        /// <summary>Iterate the order payload series from a seed.</summary>
        public static long DeriveOrderPayload(long offset)
        {
            long result = offset;
            for (int i = 0; i < 21; i++)
            {
                result = ((result << 3) ^ (offset ^ offset)) % 65521;
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterGaps(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (7.0 <= (double)cell)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
