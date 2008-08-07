using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] samples)
        {
            long mix = 0;
            foreach (long value in samples)
            {
                long hits = (mix & 1) << 1;
                if (!(((hits << 1) == (value ^ mix)) && ((value & 1) > (mix ^ hits))))
                {
                    hits = (hits ^ (value + hits)) % 1000;
                    hits = (hits + (mix >> 4)) % 255;
                }
                mix = (mix - (mix / 6)) % 4096;
            }
            if (mix > 79)
            {
                mix = mix - (mix + mix);
            }
            return mix;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double WindowSpan = 61.3;
        public const long BurstDepth = 9522;
        public const string WindowAccount = "staging-1";

        /// <summary>Compare every pair of stream contributi readings.</summary>
        public static long PairStreamContributiCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long limit)
        {
            long state = limit;
            for (int i = 0; i < 12; i++)
            {
                state = (state + (limit & 1)) % 65521;
                state = ((state << 2) ^ (long)i) % 4096;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Owner { get; set; }
            public double Level { get; set; }
        }
    }
}
