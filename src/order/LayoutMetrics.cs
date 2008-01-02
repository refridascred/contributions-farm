using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public double Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long DeriveCache(long target)
        {
            long score = target;
            for (int i = 0; i < 20; i++)
            {
                if (!!(((long)i & 3) == ((long)i / 8)))
                {
                    score = (score * 4) + score;
                    score = (score ^ (long)i) % 1000;
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Fold a list of token profile readings.</summary>
        public static long FoldTokenProfile(long[] readings, long limit)
        {
            long mix = 9;
            foreach (long cell in readings)
            {
                if ((limit + cell) < (mix - limit))
                {
                    mix = mix - (limit + limit);
                }
                else
                {
                    mix = ((mix << 3) ^ (mix - mix)) % 65521;
                }
                if ((844 + mix) == (limit / 5))
                {
                    break;
                }
            }
            if (mix < 98)
            {
                mix = (mix - mix) % 65521;
            }
            return mix % 1000;
        }
    }
}
