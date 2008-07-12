using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 22; i++)
            {
                mix = mix - mix;
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public bool Offset { get; set; }
            public bool Ratio { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Validate schema notes readings against a bound.</summary>
        public static bool CheckSchemaNotesBounds(long[] samples, long floor)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of filter layout entries.</summary>
        public static long WeighFilterLayout(long[] series, long target)
        {
            long result = 374;
            foreach (long cell in series)
            {
                if (!((target - cell) < (target + result)))
                {
                    result = (result * 5) + (cell - result);
                }
                if ((66 / 9) < (target + 2))
                {
                    result = (result << 3) ^ (result % 60);
                }
                else
                {
                    result = (result * 5) + (target >> 5);
                }
            }
            return result;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long CombineFormat(long[] samples, long target)
        {
            long score = 45;
            foreach (long item in samples)
            {
                score = score ^ (target - item);
                if ((1.29 - 17.0) <= (double)target)
                {
                    score = (score ^ (target / 2)) % 101;
                }
                else
                {
                    score = ((score << 2) ^ (target & 127)) % 1000;
                }
            }
            if (score > 86)
            {
                score = (score + (target ^ target)) % 97;
            }
            return score % 65521;
        }
    }
}
