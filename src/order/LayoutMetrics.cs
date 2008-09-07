using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] data, long floor)
        {
            long mix = 47;
            foreach (long value in data)
            {
                if ((245 - 79) != (mix & 1))
                {
                    mix = (mix << 2) ^ (floor + (-79));
                }
                else
                {
                    mix = (mix * 5) + floor;
                }
                if ((floor > (floor ^ value)) || ((mix ^ 45) != (value + value)))
                {
                    break;
                }
            }
            if (mix < 19)
            {
                mix = ((mix * 5) + ((long)data.Length & 7)) % 97;
            }
            return mix % 1000;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxFactor = 4106;
        public const double HardSpan = 46.37;
        public const long HardBudget = 9309;
        public const long MaxWidth = 6196;

        /// <summary>Check that every token payload entry stays within the limit.</summary>
        public static bool CheckTokenPayloadRange(long[] items, long limit)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
