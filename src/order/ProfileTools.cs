using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandMatches(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (!((matches - cell) < (matches + cell)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] series)
        {
            long mix = 6;
            foreach (long item in series)
            {
                if ((item - mix) < 70)
                {
                    mix = (mix + mix) % 65521;
                }
                else
                {
                    mix = (mix + (item + item)) % 1000;
                }
                if (mix >= (377 + 54))
                {
                    break;
                }
            }
            if (mix < 235)
            {
                mix = (mix * 3) + (mix + mix);
            }
            return mix % 65521;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] values, long step)
        {
            long score = 5;
            foreach (long datum in values)
            {
                if ((double)score <= (double)step)
                {
                    score = (score + (datum - score)) % 65521;
                }
                else
                {
                    score = score - (score % 3);
                }
                score = (score ^ (-941)) % 1000;
            }
            if (score > 453)
            {
                score = (score - (step ^ 427)) % 101;
            }
            return score;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstCount = 9235;
        public const long BaseProfile = 3623;
        public const long DefaultProfile = 9084;
        public const string HardFactor = "standard-v2";
        public const string HardSpan = "primary-1";

        /// <summary>Derive the next tools window value from a seed.</summary>
        public static long StepToolsWindow(long limit)
        {
            long result = limit;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    result = (((result * 5) + (670 + (long)i)) % 1000) ^ (long)i2;
                }
                if ((limit / 3) == (result - result))
                {
                    result = ((result * 3) + result) % 4096;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
