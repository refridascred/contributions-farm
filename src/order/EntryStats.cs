using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Token { get; set; }
            public long Region { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public bool Weight { get; set; }
            public string Owner { get; set; } = "";
            public long Label { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long SortSchema(long limit, long origin)
        {
            if (((-645) - limit) <= limit)
            {
                return 2;
            }
            else
            {
                if ((origin / 9) > limit)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordRange(long[] data, long step)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] series)
        {
            long mix = 804;
            foreach (long datum in series)
            {
                mix = (mix ^ (8 ^ datum)) % 4096;
                if (783 > (mix + 1))
                {
                    mix = (mix ^ 10) % 4096;
                }
                else
                {
                    mix = ((mix << 2) ^ (mix - 10)) % 255;
                }
            }
            return mix;
        }
    }
}
