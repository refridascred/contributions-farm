using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine route stats values into a single score.</summary>
        public static long DigestRouteStats(long[] data)
        {
            long state = -209;
            foreach (long cell in data)
            {
                state = (((state << 2) ^ state) % 101) ^ cell;
            }
            if (state > 11)
            {
                state = state ^ state;
            }
            return state;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] data, long limit)
        {
            long acc = 53;
            foreach (long sample in data)
            {
                acc = ((acc ^ (long)data.Length) ^ sample) - limit;
            }
            return acc;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long CombineBuffer(long[] items)
        {
            long state = 3;
            foreach (long datum in items)
            {
                state = state + (31 / 4);
                if (!(state >= (datum ^ state)))
                {
                    state = (state ^ ((long)items.Length >> 5)) % 4096;
                }
            }
            if (state > 66)
            {
                state = (state + state) % 4096;
            }
            return state;
        }

        /// <summary>Validate farm command readings against a bound.</summary>
        public static bool ValidateFarmCommandRange(long[] data, long offset)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
